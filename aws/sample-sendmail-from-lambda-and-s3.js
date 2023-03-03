var aws = require('aws-sdk');
var nodemailer = require('nodemailer');

var ses = new aws.SES();
var s3 = new aws.S3();

function getS3File(bucket, key) {
    return new Promise(function (resolve, reject) {
        s3.getObject(
            {
                Bucket: bucket,
                Key: key
            },
            function (err, data) {
                if (err) return reject(err);
                else return resolve(data);
            }
        );
    })
}

exports.handler = function (event, context, callback) {

    getS3File('esites-promote-content', 'report.txt')
        .then(function (fileData) {
            var mailOptions = {
                from: 'email@domain.com',
                subject: 'eSites Content Publishing Report',
                html: `<p>Please check the report from dry-run</p>`,
                to: 'email@domain.com',
                 bcc: (event.bccEmails!=null? event.bccEmails: ""),
                attachments: [
                    {
                        filename: "report.txt",
                        content: fileData.Body
                    }
                ]
            };

            console.log('Creating SES transporter');
            // create Nodemailer SES transporter
            var transporter = nodemailer.createTransport({
                SES: ses
            });

            // send email
            transporter.sendMail(mailOptions, function (err, info) {
                if (err) {
                    console.log(err);
                    console.log('Error sending email');
                    callback(err);
                } else {
                    console.log('Email sent successfully');
                    callback();
                }
            });
        })
        .catch(function (error) {
            console.log(error);
            console.log('Error getting attachment from S3');
            callback(err);
        });
};

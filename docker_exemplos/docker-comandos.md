
# comandos do docker:

## listar meus containers
docker container ls -a

## remover um container
docker rm nome_container

## parar um container 
docker stop nome_container

##criar um container com nome myrabbit:

`docker run -d --hostname my-rabbit --name myrabbit -p 8080:15672 -p 5672:5672 rabbitmq:3-management`


mais info: https://store.docker.com/images/rabbitmq

##ver se esta rodando
docker logs myrabbit

acessar o admin:
http://localhost:8080/#/ ou http://host-ip:8080 no browser.


# Remover todas as imagens do docker

https://techoverflow.net/2013/10/22/docker-remove-all-images-and-containers/

#!/bin/bash
`# Delete all containers
docker rm $(docker ps -a -q)
`# Delete all images
docker rmi $(docker images -q)








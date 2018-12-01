
# comandos do docker:

## listar meus containers
docker container ls -a

## remover um container
docker rm nome_container

## parar um container 
docker stop nome_container

##criar um container com nome myrabbit:
docker run -d --hostname my-rabbit --name myrabbit -p 8080:15672 rabbitmq:3-management

mais info: https://store.docker.com/images/rabbitmq

##ver se esta rodando
docker logs myrabbit

acessar o admin:
http://localhost:8080/#/ ou http://host-ip:8080 no browser.

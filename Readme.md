This is project for learning microservice technical & English
This project following the link youtube : https://www.youtube.com/watch?v=DgVjEo3OGBI
<3 Thanks for this channel

### Day 1: 
1. Init project and install all package .Net version 7 
2. Create Models Data AppDbContext.
Noted: 
-  Today im learned new knowledge is "base" keyword using in AppDbContext.cs, this constructor will call DbContext.DbContext(DbcontextOptions<AppDbContext> opt)
-  Call a method on the base class that has been overridden by another method.
-  Specify which base-class constructor should be called when creating instances of the derived class.
via link: https://learn.microsoft.com/vi-vn/dotnet/csharp/language-reference/keywords/base

### Pratice docker: 
create docker file for .net 7<br/>
command syntax im was learning for docker:<br/>

*** docker build -t <dockerid>/<dockername> .  ( for build ) *** <br/>
*** docker push <dockerid>/<dockername> ( for push to docker hub )  *** <br/>
*** docker run -p localPortNumber:dockerPortNumber -d dockerid/dockername *** <br/>
*** docker ps (list all item docker)*** <br/>
*** docker stop <dockerContainerId> (stop container id)*** <br/>
*** docker start <dockerContainerId> (start container id)*** <br/>

### Learn Kubenetes (new knowledge for me)
I created a file yaml for deployment "K8S/platforms-depl.yaml"<br/>
I created a file yaml NodePort Service  "K8S/platforms-np-srv.yaml" <br/>

command syntax im was learning for k8s: <br/>
*** kubectl apply -f <yamlnamefile>*** <br/>
*** kubectl get deployments *** <br/>
*** kubectl get pods *** <br/>
*** kubectl delete deployment <metadata.name> *** <br/>
*** kubectl get services (for get services) *** <br/>
*** kubectl delete svc <servicename> *** 
*** kubectl rollout restart deployment <deploymentname> *** 


### Day 2:
### Im Learning Kubernetes continue 

Knowledge today i'll remember and practice is: PV, PVC, StorageClass. <br/>
Today, I created a file yaml "K8S/local-pvc.yaml" to create PersistentVolumeClaim for mssql<br/>
Today, I created a file yaml for datastorage "K8S/mssql-plat-depl.yaml" for deployment mssql with map port of mssql to 1433 and loadbalancer for mssql<br/>

*** kubectl get pvc (for get PVC) ***<br/>
*** kubectl create secret generic mssql --from-literal=SA_PASSWORD="123Abc!!!" ***<br/>
*** kubectl delete secret mssql ***<br/>


### Day 3: 
### Create multi rest api url
### RabbitMQ on kubernetes (new knowledge)
1.Setting create containerzation RabbitMQ on kubernetes (K8S folder) <br/>
2.Published event to RabbitMQ (PlatformService project folder) <br/>
3.Subscribe event from RabbitMQ (CommandService project folder) <br/>
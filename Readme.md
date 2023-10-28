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
create docker file for .net 7\
docker build -t <dockerid>/<dockername> .  ( for build )\
docker push <dockerid>/<dockername> ( for push to docker hub )\
docker run -p <localport>:<dockerport> -d <dockerid>/<dockername>\
docker ps (list all item docker)\
docker stop <dockerContainerId> (stop container id)\
docker start <dockerContainerId> (start container id)\

### Learn Kubenetes (new knowledge for me)
I created a file yaml for deployment "K8S/platforms-depl.yaml"\
command syntax for k8s:\
kubectl apply -f <yaml name file> \
kubectl get deployments\
kubectl get pods\
kubectl delete deployment <metadata.name>\
kubectl get services (for get services) \
kubectl delete svc <servicename>\
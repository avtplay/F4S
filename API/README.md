Pour créer l'image docker :

cd REPO/API
docker build -t ${dcoker_image_name} .

Pour lancer l'application sous docker 
docker run -d -p 8080:80 --name alex alex_project:latest
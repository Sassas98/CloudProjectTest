# CloudProjectTest
 
Per creare l'immagine:
1. dotnet publish -c Release
2. docker build -t nome-immagine -f Dockerfile .
-------------------------------------
Per runnare un container:
1. docker create --name nome-container ... nome-immagine
2. docker start nome-container

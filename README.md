# folder-creation
Requirement to run 
  1: Docker shoud be instlled on your system
  
Steps to run utility:
step 1: Download docker-compose.yml file (https://github.com/hetal-ahir/folder-creation/blob/master/FolderCreation/deployment/docker-compose.yml)
step 2: Set volumes mount 
   2.1: Where you want to create folders 
    2.1.1: Change path "D:\testfolder\" in existing file (D:\testfolder\:/infolder)
step 3: Set environment variable:
  3.1: folderCountLimit: Number of folder you want to create
    3.1.1: Change "100" in existing file ("myconfig__folderCountLimit=100")
step 3: Open terminal(Linux/ubuntu) or cmd(windows)
step 4: Drive to folder where docker-compose.yml file
step 5: Run command docker-compose up
step 6: 

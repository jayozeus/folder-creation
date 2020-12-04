# folder-creation utility


Requirement For Windows
  1. Docker Desktop shoud be installed and running on your system
  To install please refer this link here: https://docs.docker.com/docker-for-windows/install/
  
  Requirement For Linux [ Ubuntu Bionic 18.04 (LTS)]
  2. Docker isntalled and running on system
  To install run 'sudo apt install docker.io' on your linux
  
  
Steps to run utility:
1: Download docker-compose.yml file here:  https://github.com/hetal-ahir/folder-creation/blob/master/FolderCreation/deployment/docker-compose.yml
2: Set volumes mount 
   2.1: enter path to the directory where you want to create folders 
    2.1.1: Change path "D:\testfolder\" in the docker-compose.yml file (D:\testfolder\:/infolder)
3: Set environment variable:
  3.1: folderCountLimit: Number of folders you want to create
    3.1.1: Change "100" in existing file ("myconfig__folderCountLimit=100")
4: Open terminal(Linux/ubuntu) or cmd(windows)
5: navigate to the directory where the docker-compose.yml file is
6: Run command 'docker-compose up'

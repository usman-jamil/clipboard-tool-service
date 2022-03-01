# clipboard-tool-service

The clipboard tool service will provide the backend services for enabling an efficient front-end react application. It will basically provide the following functionality:

* /clip HTTP POST method to add something to the clipboard. It can be a URL, a picture, a video or a set of files
* /clip HTTP PUT method to update an existing clip
* /clip HTTP DELETE method to delete an existing clip
* /clip/{id} GET HTTP method to get the contents of a clip
* /clips GET HTTP method to get the clips existing in the database (implement paging later)

## Tools

* .Net Core 5 should be used to implement the API endpoints
* Postgres will be used as the backend
* The blobs i.e. images/files/videos will be stored inside an Azure Blob Store. The links to the images will be saved inside the database.
* The database will contain only 2 tables i.e. Clips, and Resources. Resources will be a child table which will contain the data associated with each clip i.e. Images/Files/Videos etc.

## ER Diagram
![image](https://user-images.githubusercontent.com/4136805/156215814-7c39604a-844a-4e12-a88c-21fb020985e5.png)

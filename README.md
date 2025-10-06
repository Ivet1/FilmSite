Topic: Movie Catalog
Goals and Purpose:
This relatively simple movie catalog software aims to provide a convenient and intuitive way to organize and access a collection of movies. It allows users to view information about various movies, including titles, directors, cast, genres, and release years. 
The catalog contains a small number of movies (11). It can help maintain an organized database where each movie is easily accessible and well presented with its information. This can include movie covers, summaries, ratings, and personal notes or reviews.
Development and Functionalities:
A multi-layer model is used for the software.
Database: There are 2 databases, one is used for the Log in page which is contained by a fixed username: admin and password: Admin123; 
The other is for the title page which contains a table of 8 columns: MovieID, Title, ReleaseYear, Genre, Director, Rating, Description, and PostreImage.

Classes: Two classes are used
This is the `Movie` class, it contains the following properties:
- `MovieID`: This is a property of type `int`, which represents a unique identifier of the movie.
- `Title`: This is a property of type `string`, which represents the title of the movie.
- `ReleaseYear`: This is a property of type `int`, which represents the year of release of the movie.
- `Genre`: This is a property of type `string`, which represents the genre of the movie.
- `Rating`: This is a property of type `double`, which represents the rating of the movie.
- `Description`: This is a property of type `string`, which represents a description of the movie.
- `PosterImage`: This is a property of type `string`, which represents a poster of the movie.
- `Director`: This is a property of type `string`, which represents the director of the movie.

All these properties can be modified and retrieved, which is indicated by `{ get; set; }` after each property. This means that they are readable and writable.
The other is a static class `MovieArrayCreator` in C#. The class contains the following elements:
- `movies`: This is a static array of `Movie` objects. It is used to store the movies retrieved from the database.
- `CreateMoviesArrayAsync`: This is an asynchronous method that creates an array of movies. It takes a `connectionString` as a parameter, which is used to connect to the database.
-  Inside the method, `SqlConnection` is used to open a connection to the database.
- Then, a SQL query is executed that retrieves information about all the movies.
-  The results of the query are populated in `DataTable`. Then, `DataTable` is traversed and for each row, a new `Movie` object is created and added to the `movies` array. Finally, the method returns the `movies` array.
This code is a typical example of retrieving data from a database and converting it into objects in the program. This is a common approach in programming, known as Object-Relational Mapping (ORM).
Application functionality: It consists of two pages (Login and Home)
The first is the Login page through which to go to the home page.
 It contains 3 buttons, such as "exit" to exit the page, the "clear" button to clear the text in the "username" and "password" fields in which you must write a fixed username: admin and password: Admin123. And "Enter" is used to go to the home page.
The home page has "EXIT" and "Load all movies" buttons. The "EXIT" button exits the page, and the "Load all movies" button loads movie titles. When you click on one of the movie titles, a window with the movie cover and information about it appears below.

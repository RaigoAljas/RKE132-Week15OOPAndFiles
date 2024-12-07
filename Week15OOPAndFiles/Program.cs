
List <Movie> myMovies = new List<Movie>(); 
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);
//ReadDataFromArray(GetDataFromMyFile());

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    //Console.WriteLine("Temp array");
    //ReadDataFromArray(tempArray);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie); 
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favourite movies {movie.Title} was released in {movie.Year}.");
}


static string[] GetDataFromMyFile()
{
    string filePath = @"C:\data\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filePath);
    //return dataFromFile;
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string Line in someArray)
    {
        Console.WriteLine(Line);
    }
}

class Movie
{
    string title;   //fields
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}






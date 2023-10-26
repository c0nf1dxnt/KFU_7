namespace Part1
{
    class Song
    {
        public string name { get; set; }
        public string author { get; set; }
        public Song previousSong { get; set; }
        public Song(string Name, string Author, Song PreviousSong = null)
        {
            name = Name;
            author = Author;
            previousSong = PreviousSong;
        }
        public string Title()
        {
            return $"{name} - {author}";
        }
        public bool CheckForSimilarity(Song comparableSong)
        {
            return name == comparableSong.name && author == comparableSong.author;
        }
    }
}

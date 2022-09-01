namespace PLaylisten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates a new objekts called playlist
            Playlist playlist = new Playlist();

            //Adds the track Pianoman and Mr. Sandman to the linkedlist using the AddTrack method
            playlist.AddTrack("Pianoman");
            playlist.AddTrack("Mr. Sandman");

            //Adds the track Fly me to the moon to the top of the linked list
            playlist.AddTrackAtTop("Fly me to the moon");

            //Writes out the linked list from the objekt playlist
            foreach (Track t in playlist.playlist)
            {
                Console.WriteLine(t.TrackName);
            }

        }
    }
}
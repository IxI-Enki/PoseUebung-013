using MusicStore.Logic;
using MusicStore.Logic.DataContext;

namespace MusicStore.ConApp;

internal class Program
{
        static void Main()
        {
                int index = 1;
                string input = string.Empty;
                MusicStoreContext context = new();

                // PrintGenres(context);
                // PrintAlbums(context);

                while (input.ToLower() != "x")
                {
                        Console.Clear();
                        Console.WriteLine("         MusicStore         ".BackgroundColor("45,225,110").ForegroundColor("black"));
                        Console.WriteLine("============================\n".ForegroundColor("45,225,110"));

                        Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintArtistAndAlbum)}....{index++}".ForegroundColor("0,255,155"));
                        Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintArtistAndTracks)}...{index++}".ForegroundColor("15,245,140"));
                        Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintArtistAndTimes)}....{index++}".ForegroundColor("30,235,125"));
                        Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintAlbumAndTracks)}....{index++}".ForegroundColor("45,225,110"));
                        Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintAlbumAndTimes)}.....{index++}".ForegroundColor("60,215,95"));
                        Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintAverageByGenre)}....{index++}".ForegroundColor("75,205,80"));
                        Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintAverageByAlbum)}....{index++}".ForegroundColor("90,195,65"));
                        Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintAverageByTrack)}....{index++}".ForegroundColor("105,185,50"));
                        Console.WriteLine($"{nameof(Logic.Statistics.MusicStoreStatistics.PrintGenreAndTitles)}....{index++}".ForegroundColor("120,175,35"));

                        Console.WriteLine();
                        Console.WriteLine($"Exit...................x".ForegroundColor("red"));
                        Console.Write("\nYour choice:".BackgroundColor("255,255,255").ForegroundColor("black") + " ");

                        input = Console.ReadLine()!;

                        if (input == string.Empty)
                                index = 1;

                        if (Int32.TryParse(input , out int choice))
                        {
                                switch (choice)
                                {
                                        case 1:
                                                Logic.Statistics.MusicStoreStatistics.PrintArtistAndAlbum(context);
                                                break;
                                        case 2:
                                                Logic.Statistics.MusicStoreStatistics.PrintArtistAndTracks(context);
                                                break;
                                        case 3:
                                                Logic.Statistics.MusicStoreStatistics.PrintArtistAndTimes(context);
                                                break;
                                        case 4:
                                                Logic.Statistics.MusicStoreStatistics.PrintAlbumAndTracks(context);
                                                break;
                                        case 5:
                                                Logic.Statistics.MusicStoreStatistics.PrintAlbumAndTimes(context);
                                                break;
                                        case 6:
                                                Logic.Statistics.MusicStoreStatistics.PrintAverageByGenre(context);
                                                break;
                                        case 7:
                                                Logic.Statistics.MusicStoreStatistics.PrintAverageByAlbum(context);
                                                break;
                                        case 8:
                                                Logic.Statistics.MusicStoreStatistics.PrintAverageByTrack(context);
                                                break;
                                        case 9:
                                                Logic.Statistics.MusicStoreStatistics.PrintGenreAndTitles(context);
                                                break;
                                        default:
                                                break;
                                }
                                index = 1;
                                Console.WriteLine();
                                Console.Write("Continue with Enter...");
                                Console.ReadLine();
                        }
                }
        }

        private static void PrintGenres(MusicStoreContext context)
        {
                Console.WriteLine();
                Console.WriteLine("Genres:");
                Console.WriteLine("-------");

                foreach (var item in context.GenreSet)
                        Console.WriteLine($"{item}");
        }

        private static void PrintArtists(MusicStoreContext context)
        {
                Console.WriteLine();
                Console.WriteLine("Artists:");
                Console.WriteLine("-------");

                foreach (var item in context.ArtistSet)
                        Console.WriteLine($"{item}");
        }

        private static void PrintAlbums(MusicStoreContext context)
        {
                Console.WriteLine();
                Console.WriteLine("Albums:");
                Console.WriteLine("-------");

                foreach (var item in context.AlbumSet)
                        Console.WriteLine($"{item}");
        }

        private static void PrintTracks(MusicStoreContext context)
        {
                Console.WriteLine();
                Console.WriteLine("Tracks:");
                Console.WriteLine("-------");

                foreach (var item in context.TrackSet)
                        Console.WriteLine($"{item}");
        }
}

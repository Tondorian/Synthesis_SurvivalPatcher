using Mutagen.Bethesda.Plugins.Order;
using Mutagen.Bethesda.Skyrim;

namespace SurvivalPatcher
{
    public static class LoadOrderUtilities
    {
        public static ISkyrimModGetter? GetModByFileName(this ILoadOrder<IModListing<ISkyrimModGetter>> LoadOrder, string fileName)
        {
            try
            {
                return LoadOrder[LoadOrder.Keys.Where(x => ((string)x.FileName).ToLower() == fileName.ToLower()).ToList().First()].Mod;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("ESP not found: " + fileName + ". This means you have missing masters.");
                throw;
            }
        }
    }
}

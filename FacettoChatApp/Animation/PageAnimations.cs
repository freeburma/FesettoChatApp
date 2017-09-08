
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace FasettoChatApp
{
    /// <summary>
    /// Helpers to animate pages in specific ways 
    /// </summary>
    public static class PageAnimations
    {
        /// <summary>
        /// Slides a page in from the right 
        /// </summary>
        /// <param name="page"> The page to animate </param>
        /// <param name="seconds"> The time the animation will take </param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight (this Page page, float seconds)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Add slide for animation
            sb.AddSlideFromRight(seconds, page.WindowWidth);

            // Add Fade In
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait for it to finish 
            await Task.Delay((int) seconds * 1000);

        }// end SlideAndFadeInFromRight ()

        /// <summary>
        /// Slides a page out to the left
        /// </summary>
        /// <param name="page"> The page to animate </param>
        /// <param name="seconds"> The time the animation will take </param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this Page page, float seconds)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Add slide for animation
            sb.AddSlideToLeft(seconds, page.WindowWidth);

            // Add Fade In
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait for it to finish 
            await Task.Delay((int)seconds * 1000);

        }// end SlideAndFadeInFromRight ()

    }// end class 
}

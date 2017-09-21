﻿
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    /// <summary>
    /// Helpers to animate framework elements in specific ways 
    /// </summary>
    public static class FrameworkElementAnimations
    {
        /// <summary>
        /// Slides an element in from the right 
        /// </summary>
        /// <param name="element"> The element to animate </param>
        /// <param name="seconds"> The time the animation will take </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation </param>
        /// <param name="width" > The animation width to animate to. If not specified the element width is used. </param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRightAsync (this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Add slide for animation
            sb.AddSlideFromRight(seconds, width == 0 ? element.ActualWidth : width, keepMargin:keepMargin);

            // Add Fade In
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish 
            await Task.Delay((int) seconds * 1000);

        }// end SlideAndFadeInFromRight ()

        /// <summary>
        /// Slides an element in from the left 
        /// </summary>
        /// <param name="element"> The element to animate </param>
        /// <param name="seconds"> The time the animation will take </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation </param>
        /// <param name="width" > The animation width to animate to. If not specified the element width is used. </param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Add slide for animation
            sb.AddSlideFromLeft(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

            // Add Fade In
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish 
            await Task.Delay((int)seconds * 1000);

        }// end SlideAndFadeInFromRight ()

        /// <summary>
        /// Slides an element out to the left
        /// </summary>
        /// <param name="element"> The page to animate </param>
        /// <param name="seconds"> The time the animation will take </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation </param>
        /// <param name="width" > The animation width to animate to. If not specified the element width is used. </param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Add slide for animation
            sb.AddSlideToLeft(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

            // Add Fade In
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish 
            await Task.Delay((int)seconds * 1000);

        }// end SlideAndFadeInFromRight ()

        /// <summary>
        /// Slides an element out to the right
        /// </summary>
        /// <param name="element"> The page to animate </param>
        /// <param name="seconds"> The time the animation will take </param>
        /// <param name="width" > The animation width to animate to. If not specified the element width is used. </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation </param>
        /// <param name="width" > The animation width to animate to. If not specified the element width is used. </param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Add slide for animation
            sb.AddSlideToRight(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

            // Add Fade In
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish 
            await Task.Delay((int)seconds * 1000);

        }// end SlideAndFadeInFromRight ()


    }// end class 
}

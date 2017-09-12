using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    /// <summary>
    /// Animation helpers for <see cref="StoryBoard"/>
    /// </summary>
    public static class StoryboardHelpers
    {
        /// <summary>
        /// Add a slide from right in animation to the storyboard.
        /// </summary>
        /// <param name="storyboard"> THe storyboard to add the animation </param>
        /// <param name="seconds"> The time of the animation will take </param>
        /// <param name="offset"> The distance to the right to start from </param>
        /// <param name="decelerationRatio"> The rate of decelaration </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation </param>
        public static void AddSlideFromRight (this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);

        }// end AddSlideFromRight()

        /// <summary>
        /// Add a slide from left in animation to the storyboard.
        /// </summary>
        /// <param name="storyboard"> THe storyboard to add the animation </param>
        /// <param name="seconds"> The time of the animation will take </param>
        /// <param name="offset"> The distance to the left to start from </param>
        /// <param name="decelerationRatio"> The rate of decelaration </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation </param>
        /// 
        public static void AddSlideFromLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);

        }// end AddSlideFromRight()


        /// <summary>
        /// Add a slide to left in animation to the storyboard.
        /// </summary>
        /// <param name="storyboard"> THe storyboard to add the animation </param>
        /// <param name="seconds"> The time of the animation will take </param>
        /// <param name="offset"> The distance to the right to start from </param>
        /// <param name="decelerationRatio"> The rate of decelaration </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation </param>
        /// 
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);

        }// end AddSlideFromRight()

        /// <summary>
        /// Add a slide to right in animation to the storyboard.
        /// </summary>
        /// <param name="storyboard"> THe storyboard to add the animation </param>
        /// <param name="seconds"> The time of the animation will take </param>
        /// <param name="offset"> The distance to the right to end at </param>
        /// <param name="decelerationRatio"> The rate of decelaration </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation </param>
        /// 
        public static void AddSlideToRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);

        }// end AddSlideFromRight()


        /// <summary>
        /// Add a slide and fade in animation to the storyboard.
        /// </summary>
        /// <param name="storyboard"> THe storyboard to add the animation </param>
        /// <param name="seconds"> The time of the animation will take </param>
        /// <param name="offset"> The distance to the right to start from </param>
        /// <param name="decelerationRatio"> The rate of decelaration </param>
        public static void AddFadeIn(this Storyboard storyboard, float seconds)
        {
            // Create the margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1,
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);

        }// end AddFadeIn()

        /// <summary>
        /// Add a fade out animation to the storyboard.
        /// </summary>
        /// <param name="storyboard"> THe storyboard to add the animation </param>
        /// <param name="seconds"> The time of the animation will take </param>
        /// <param name="offset"> The distance to the right to start from </param>
        /// <param name="decelerationRatio"> The rate of decelaration </param>

        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {
            // Create the margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0,
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);

        }// end AddFadeIn

    }// end class
}

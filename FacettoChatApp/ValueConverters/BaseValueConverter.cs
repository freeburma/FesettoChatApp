﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace FasettoChatApp
{
    /// <summary>
    /// A base value converter taht allows direct XML usage
    /// 
    /// MarkupExtension: Allows us to use directly inside the XML main.
    /// </summary>
    /// <typeparam name="T"> The type of this value converter </typeparam>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T : class, new ()         // Defining the T as a class 
    {
        #region Private Members 
        
        /// <summary>
        /// A single static instance of this value converter
        /// </summary>
        private static T mConverter = null;

        #endregion

        #region Markup Extension Methods
        /// <summary>
        /// Provides a static instance of the value converter
        /// </summary>
        /// <param name="serviceProvider"> The service provider </param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            /*
                if (mConverter == null)
                    return mConverter = new T(); 
                else 
                    return mConverter; 
             */
            return mConverter ?? (mConverter = new T()); 
        }

        #endregion  

        #region Value Converter Methods 

        /// <summary>
        /// The method to convert one type to another 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);


        /// <summary>
        /// The method to convert a value back to it's source type.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        #endregion


    }// end class
}

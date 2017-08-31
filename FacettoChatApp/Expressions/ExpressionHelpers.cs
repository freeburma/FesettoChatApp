﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FacettoChatApp
{
    /// <summary>
    /// Helper for expressions
    /// </summary>
    public static class ExpressionHelpers
    {
        /// <summary>
        /// Compiles an expression and gets the function.
        /// </summary>
        /// <typeparam name="T"> The type of return value </typeparam>
        /// <param name="lambda"> The expression to compile. </param>
        /// <returns></returns>
        public static T GetPropertyValue<T> (this Expression <Func<T>> lambda)
        {
            return lambda.Compile().Invoke(); // Creating a function at Runtime.
        }


        /// <summary>
        /// Sets the underlying properties value to the given value, form an expression that contains the property
        /// </summary>
        /// <typeparam name="T"> The type of the value to set </typeparam>
        /// <param name="lambda"> The Expression </param>
        /// <param name="value"> The value to set the property </param>
        public static void SetPropertyValue<T> (this Expression<Func<T>> lambda, T value)
        {
            // Converts a lambda () => some.Property, to some.Property.
            var expression = (lambda as LambdaExpression).Body as MemberExpression;

            // Get the propetyt inf so we can set it 
            var propertyInfo = (PropertyInfo)expression.Member;

            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke(); // Invoke at runtime.

            // Set the property value.
            propertyInfo.SetValue(target, value);
        }

    }//ed class
}

﻿// Copyright (c) 2016 Ratish Philip 
//
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions: 
// 
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software. 
// 
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE. 
//
// This file is part of the CompositionProToolkit project: 
// https://github.com/ratishphilip/CompositionProToolkit
//
// CompositionProToolkit v0.4.6
//

using System;

namespace CompositionProToolkit.Expressions
{
    /// <summary>
    /// Extension methods for System.Double
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Converts double value to float
        /// </summary>
        /// <param name="value">double value</param>
        /// <returns>float</returns>
        public static float Single(this double value)
        {
            // Double to float conversion can overflow.
            try
            {
                return Convert.ToSingle(value);
            }
            catch (OverflowException ex)
            {
                throw new ArgumentOutOfRangeException("Cannot convert the double value to float!", ex);
            }
        }
    }
}

//
// Strings.cs
//
// Author:
//   Aaron Bockover <abock@rd.io>
//
// Copyright 2012 Rdio, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

using Vernacular;

namespace Vernacular.Test
{
    public static class Strings
    {
        public static string NeutralSingular ()
        {
            return Catalog.GetString ("NeutralSingular",
                comment: "comment=NeutralSingular");
        }

        public static string NeutralPlural (int n)
        {
            return Catalog.GetPluralString ("NeutralPlural:P0", "NeutralPlural:P1",
                n, comment: "comment=NeutralPlural");
        }

        public static string GenderSingular (LanguageGender gender)
        {
            return Catalog.GetGenderString (gender,
                "GenderSingular:M", "GenderSingular:F",
                comment: "comment=GenderSingular");
        }

        public static string GenderPlural (LanguageGender gender, int n)
        {
            return Catalog.GetPluralGenderString (gender,
                "GenderPlural:P0:M", "GenderPlural:P1:M",
                "GenderPlural:P0:F", "GenderPlural:P1:F",
                n, comment: "comment=GenderPlural");
        }
    }
}
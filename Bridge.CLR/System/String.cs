﻿using Bridge.CLR;

namespace System
{
    [Ignore]
    [Name("String")]
    [Constructor("String")]
    public sealed class String
    {
        public readonly int Length = 0;

        public static string FromCharCode(params int[] chars) 
        { 
            return null; 
        }

        public String() 
        { 
        }
        
        public String(object obj) 
        { 
        }

        public string CharAt(int pos) 
        { 
            return null; 
        }
        
        public int CharCodeAt(int pos) 
        { 
            return 0; 
        }

        public static string Concat(string s1, string s2)
        {
            return null;
        }

        public static string Concat(string s1, string s2, string s3)
        {
            return null;
        }

        public static string Concat(string s1, string s2, string s3, string s4)
        {
            return null;
        }

        
        public static string Concat(params string[] strings)
        {
            return null;
        }

        
        public static string Concat(object o1, object o2)
        {
            return null;
        }

        
        public static string Concat(object o1, object o2, object o3)
        {
            return null;
        }

        
        public static string Concat(object o1, object o2, object o3, object o4)
        {
            return null;
        }

        
        public static string Concat(params object[] o)
        {
            return null;
        }

        public int IndexOf(string searchString) 
        { 
            return 0; 
        }

        public int IndexOf(string searchString, int position) 
        { 
            return 0; 
        }

        public int LastIndexOf(string searchString) 
        { 
            return 0; 
        }

        public int LastIndexOf(string searchString, int position) 
        { 
            return 0; 
        }

        public int LocaleCompare(object that) 
        { 
            return 0; 
        }

        public string[] Match(RegExp regexp) 
        { 
            return null; 
        }

        public string[] Match(string regexp) 
        { 
            return null; 
        }

        public string Replace(RegExp regexp, string replacement) 
        { 
            return null; 
        }

        public string Replace(RegExp regexp, Func<string, string> callback) 
        { 
            return null; 
        }

        public string Replace(RegExp regexp, Func<string, int, string> callback) 
        { 
            return null; 
        }

        public string Replace(RegExp regexp, Func<string, int, string, string> callback) 
        { 
            return null; 
        }

        public string Replace(string regexp, string replacement) 
        { 
            return null; 
        }

        public string Replace(string regexp, Func<string, string> callback) 
        { 
            return null; 
        }

        public string Replace(string regexp, Func<string, int, string> callback) 
        { 
            return null; 
        }

        public string Replace(string regexp, Func<string, int, string, string> callback)
        { 
            return null; 
        }

        public int Search(RegExp regexp) 
        { 
            return 0; 
        }
        
        public int Search(string regexp) 
        { 
            return 0; 
        }

        public string Slice(int start) 
        { 
            return null; 
        }

        public string Slice(int start, int end) 
        { 
            return null; 
        }

        public string[] Split(string separator) 
        { 
            return null; 
        }

        public string[] Split(RegExp separator) 
        { 
            return null; 
        }

        public string[] Split(string separator, int limit) 
        { 
            return null; 
        }

        public string[] Split(RegExp separator, int limit) 
        { 
            return null; 
        }

        public string Substring(int start) 
        { 
            return null; 
        }

        public string Substring(int start, int end) 
        { 
            return null; 
        }

        public string Substr(int start) 
        { 
            return null; 
        }

        public string Substr(int start, int length) 
        { 
            return null; 
        }

        public string ToLowerCase() 
        { 
            return null; 
        }
        
        public string ToLocaleLowerCase() 
        { 
            return null; 
        }
        
        public string ToUpperCase() 
        { 
            return null; 
        }
        
        public string ToLocaleUpperCase() 
        { 
            return null; 
        }

        public static bool operator ==(string s1, string s2)
        {
            return false;
        }

        public static bool operator !=(string s1, string s2)
        {
            return false;
        }

    }
}
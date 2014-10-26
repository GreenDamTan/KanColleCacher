﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_f_32.KanColleCacher
{
    public static class UriExtension
    {
        public static bool IsFilePath(this Uri uri)
        {
            return uri.Segments.Last().IndexOf('.') >= 0;
        }
        //AbsoluteUrl   = http://www.contoso.com/catalog/shownew.htm?date=today 
        //AbsolutePath  =  /catalog/shownew.htm
        //PathAndQuery  = /catalog/shownew.htm?date=today

        //Segments      = (string[]) {/, catalog/, shownew.htm} (绝对路径的片段)
        //Fragment     返回#后的内容（书签，#不含）
    }
}

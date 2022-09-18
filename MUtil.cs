﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Microsoft.Win32;

namespace MUtil
{
    public static partial class MUtil
    {
        /// <summary>
        /// 指定した種類のファイルを選択させ、選択されたファイルパスを返します。
        /// </summary>
        /// <param name="filetype">選択させるファイルの種類フォーマット</param>
        /// <param name="msg">ダイアログに表示する内容</param>
        /// <param name="initdir">ダイアログを表示した際のパス</param>
        /// <returns></returns>
        public static string SelectFile(string filetype,string msg="",string initdir="")
        {
            Console.WriteLine("Select File");
            var dialog = new OpenFileDialog();
            dialog.Filter = filetype;
            dialog.Title = msg;
            dialog.InitialDirectory = initdir == "" ? null : initdir;
            dialog.ShowDialog();
            Console.WriteLine(dialog.FileName);
            return dialog.FileName;
        }

        /// <summary>
        /// 指定したパスのフォルダ名を返します。
        /// </summary>
        /// <param name="path">ファイルパス</param>
        /// <returns></returns>
        public static string GetDir(string path)
        {
            if (path == null || path == "") return "";
            return System.IO.Path.GetDirectoryName(path);
        }

        /// <summary>
        /// 指定したファイルの拡張子が指定した拡張子と一致するかどうかを返します。
        /// 大文字小文字関係なく判定します。
        /// </summary>
        /// <param name="path">ファイルパス</param>
        /// <param name="ext">対象の演算子</param>
        /// <returns></returns>
        public static bool IsEXT(string path,string ext)
        {
            var s = System.IO.Path.GetExtension(path);
            return String.Compare(s,ext,true) == 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TicTacToe
{
    static public class Locale
    {
        static private Dictionary<string, Dictionary<string, string>> texts = new Dictionary<string, Dictionary<string, string>>();
        static public List<LocaleID> Locales = new List<LocaleID>();
        static private string currLocale;

        static Locale()
        {
            currLocale = CultureInfo.CurrentCulture.Name;
        }

        static public void SetLocale(string locale)
        {
            currLocale = locale;
        }

        static public void AddLocale(string locale, string resources)
        {
            texts.Add(locale, ParseIni(resources));
            Locales.Add(new LocaleID(T("LanguageName", locale), locale));
        }

        private static Dictionary<string, string> ParseIni(string resources)
        {
            string pattern = @"
^                           # Beginning of the line
((?:\[)                     # Section Start
     (?<Section>[^\]]*)     # Actual Section text into Section Group
 (?:\])                     # Section End then EOL/EOB
 (?:[\r\n]{0,}|\Z))         # Match but don't capture the CRLF or EOB
 (                          # Begin capture groups (Key Value Pairs)
  (?!\[)                    # Stop capture groups if a [ is found; new section
  (?<Key>[^=]*?)            # Any text before the =, matched few as possible
  (?:=)                     # Get the = now
  (?<Value>[^\r\n]*)        # Get everything that is not an Line Changes
  (?:[\r\n]{0,4})           # MBDC \r\n
  )+                        # End Capture groups";

            return (from Match m in Regex.Matches(resources, pattern, RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline)
                    select new
                    {
                        Section = m.Groups["Section"].Value,

                        kvps = (from cpKey in m.Groups["Key"].Captures.Cast<Capture>().Select((a, i) => new { a.Value, i })
                                join cpValue in m.Groups["Value"].Captures.Cast<Capture>().Select((b, i) => new { b.Value, i }) on cpKey.i equals cpValue.i
                                select new KeyValuePair<string, string>(cpKey.Value, cpValue.Value)).ToDictionary(kvp => kvp.Key, kvp => kvp.Value)

                    }).ToDictionary(itm => itm.Section, itm => itm.kvps).First().Value;
        }

        public static string T(string resourceName, string locale = null)
        {
            locale = locale == null ? currLocale : locale;
            try
            {
                return texts[locale][resourceName];
            }
            catch
            {
                if(locale == "")
                {
                    return resourceName;
                }
                return T(resourceName, Fallback(locale));
            }
        }

        private static string Fallback(string locale)
        {
            List<string> parts = locale.Split('-').ToList<string>();
            parts.Remove(parts.Last<string>());
            return String.Join("-", parts.ToArray());
        }

        public static LocaleID GetBestLocale(string locale = null)
        {
            locale = locale == null ? currLocale : locale;
            LocaleID id = Locales.Find(i => i.Value == locale);
            if (id == null)
            {
                if (locale == "")
                {
                    return null;
                }
                return GetBestLocale(Fallback(locale));
            }
            return id;
        }
        public static void LocalizeControl(Control parent)
        {
            if (parent.Tag == null)
            {
                parent.Tag = parent.Text;
            }
            if (parent.Tag.ToString() != "noLocalization")
            {
                parent.Text = Locale.T(parent.Tag.ToString());
                foreach (Control child in parent.Controls)
                {
                    LocalizeControl(child);
                }
            }
        }
    }
}

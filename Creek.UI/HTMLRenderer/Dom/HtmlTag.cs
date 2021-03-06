// "Therefore those skilled at the unorthodox
// are infinite as heaven and earth,
// inexhaustible as the great rivers.
// When they come to an end,
// they begin again,
// like the days and months;
// they die and are reborn,
// like the four seasons."
// 
// - Sun Tsu,
// "The Art of War"

using System.Collections.Generic;
using Creek.UI.HTMLRenderer.Utils;

namespace Creek.UI.HTMLRenderer.Dom
{
    internal sealed class HtmlTag
    {
        #region Fields and Consts

        /// <summary>
        /// collection of attributes and thier value the html tag has
        /// </summary>
        private readonly Dictionary<string, string> _attributes;

        /// <summary>
        /// the name of the html tag
        /// </summary>
        private readonly string _name;

        #endregion

        /// <summary>
        /// Init.
        /// </summary>
        /// <param name="name">the name of the html tag</param>
        /// <param name="attributes">collection of attributes and thier value the html tag has</param>
        /// <param name="text">the text sub-string of the html element</param>
        public HtmlTag(string name, Dictionary<string, string> attributes = null)
        {
            ArgChecker.AssertArgNotNullOrEmpty(name, "name");

            _name = name;
            _attributes = attributes;
        }

        /// <summary>
        /// Gets the name of this tag
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Gets collection of attributes and thier value the html tag has
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return _attributes; }
        }

        /// <summary>
        /// Gets if the tag is single placed; in other words it doesn't need a closing tag; 
        /// e.g. &lt;br&gt;
        /// </summary>
        public bool IsSingle
        {
            get { return HtmlUtils.IsSingleTag(Name); }
        }

        /// <summary>
        /// is the html tag has attributes.
        /// </summary>
        /// <returns>true - has attributes, false - otherwise</returns>
        public bool HasAttributes()
        {
            return _attributes != null && _attributes.Count > 0;
        }

        /// <summary>
        /// Gets a boolean indicating if the attribute list has the specified attribute
        /// </summary>
        /// <param name="attribute">attribute name to check if exists</param>
        /// <returns>true - attribute exists, false - otherwise</returns>
        public bool HasAttribute(string attribute)
        {
            return _attributes != null && _attributes.ContainsKey(attribute);
        }

        /// <summary>
        /// Get attribute value for given attribute name or null if not exists.
        /// </summary>
        /// <param name="attribute">attribute name to get by</param>
        /// <param name="defaultValue">optional: value to return if attribute is not specified</param>
        /// <returns>attribute value or null if not found</returns>
        public string TryGetAttribute(string attribute, string defaultValue = null)
        {
            return _attributes != null && _attributes.ContainsKey(attribute) ? _attributes[attribute] : defaultValue;
        }

        public override string ToString()
        {
            return string.Format("<{0}>", _name);
        }
    }
}
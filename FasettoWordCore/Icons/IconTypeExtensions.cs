namespace FasettoWordCore
{
    public static class IconTypeExtensions
    {
        /// <summary>
        /// Maps the <see cref="IconType"/> to the corresponding FontAwesome string.
        /// </summary>
        /// <param name="iconType">The icon type to map.</param>
        /// <returns>The FontAwesome string corresponding to the icon type.</returns>
        public static string ToFontAwesome(this IconType iconType)
        {
            return iconType switch
            {
                IconType.File => "\uf0f6",
                IconType.Picture => "\uf1c5",
                _ => null
            };
        }
    }
}

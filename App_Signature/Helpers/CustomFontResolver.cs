using PdfSharpCore.Fonts;


namespace App_Signature.Helpers
{
    class CustomFontResolver : IFontResolver
    {
        public string DefaultFontName => "Montserrat-Regular";

        public byte[] GetFont(string faceName)
        {
            string fontFileName = $"{faceName}.ttf";
            using (Stream fontStream = typeof(CustomFontResolver).Assembly.GetManifestResourceStream("App_Signature.Resources.Raw." + fontFileName))
            {
                if (fontStream == null)
                {
                    throw new FileNotFoundException("Font not found: " + fontFileName);
                }
                byte[] fontData = new byte[fontStream.Length];
                fontStream.Read(fontData, 0, fontData.Length);
                return fontData;
            }
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            return new FontResolverInfo(familyName, isBold, isItalic);
        }
    }
}

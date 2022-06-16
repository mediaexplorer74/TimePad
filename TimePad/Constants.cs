namespace TimePad
{
    public static class Constants
    {
        public const string TimePadAPIGetEvents =
            //"https://api.timepad.ru/v1/events/" +
            //"?cities=%D0%9C%D0%BE%D1%81%D0%BA%D0%B2%D0%B0%D0%B3&fields=location,ends_at,poster_image,description_short,description_html,organization,ticket_types&sort=+starts_at";
            "https://api.timepad.ru/v1/events/?limit=100&skip=0&cities=Москва" +
            "&fields=location,ends_at,poster_image,description_short,description_html,organization,ticket_types,widgets" +
            "&sort=+starts_at&show_empty_fields=true";

        public const string TimePadAPIGetUserInfo =
            "https://api.timepad.ru/v1/introspect/";
    }
}

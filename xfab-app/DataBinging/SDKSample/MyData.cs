namespace xfab_app.DataBinging.SDKSample
{
    public class MyData
    {
        private string colorName = "Green";
        private int width = 500;

        public string Title { get; set; }

        public int Width
        {
            get => width;
            set => width = value;
        }

        public string ColorName
        {
            get => colorName;
            set => colorName = value;
        }
    }
}
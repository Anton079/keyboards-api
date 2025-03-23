namespace keyboards_api.Keyboards.Dtos
{
    public class AddKeyboardRequest
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public int? Price { get; set; }
    }
}

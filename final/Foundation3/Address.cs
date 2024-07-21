class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public override string ToString()
    {
        return $"{Street}\n{City},\n{StateProvince}\n{Country}";
    }
}
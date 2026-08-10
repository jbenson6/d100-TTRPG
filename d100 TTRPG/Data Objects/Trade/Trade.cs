namespace d100_TTRPG.Data_Objects.Trade
{
    public class Trade
    {
        public TradeDefinition Definition { get; set; }
        public Trade(TradeDefinition definition)
        {
            Definition = definition;
        }
    }
}
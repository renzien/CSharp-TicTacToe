class Player : Piece
{
    string symbol;

    public Player(string symbol)
    {
        this.symbol = symbol;
    }

    public override string Value()
    {
        return symbol;
    }
}
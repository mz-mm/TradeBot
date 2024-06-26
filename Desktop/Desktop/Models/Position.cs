﻿using Desktop.Enums;

namespace Desktop.Models;

public class Position
{
    public string UserID { get; set; }
    public Coin Coin { get; set; }
    public int Quantity { get; set; }

    public int EntryPrice { get; set; }
    public int ExitPrice { get; set; }

    public PositionType Type { get; set; }

    public PositionStatus Status { get; set; }

}

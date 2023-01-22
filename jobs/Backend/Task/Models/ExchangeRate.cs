﻿using System;

namespace ExchangeRateUpdater.Models;

public class ExchangeRate
{
    public ExchangeRate(Currency sourceCurrency, Currency targetCurrency, decimal value)
    {
        SourceCurrency = sourceCurrency;
        TargetCurrency = targetCurrency;
        Value = value;
    }

    public Currency SourceCurrency { get; }

    public Currency TargetCurrency { get; }

    public decimal Value { get; }

    public override string ToString()
    {
        return $"{SourceCurrency}/{TargetCurrency}={Value}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        return Equals(obj as ExchangeRate);
    }

    public bool Equals(ExchangeRate other)
    {
        return Equals(SourceCurrency, other.SourceCurrency)
            && Equals(TargetCurrency, other.TargetCurrency)
            && Value == other.Value;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(SourceCurrency, TargetCurrency, Value);
    }
}
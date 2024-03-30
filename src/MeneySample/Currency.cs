﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MeneySample;

public readonly struct Currency
{
  private Currency(string code) => Code = code;
  private string Code { get; }

  public override string ToString() => Code;

  public static readonly Currency None;
  public static readonly Currency UnitedStatesDollar = new(code: "USD");
  public static readonly Currency Euro               = new(code: "EUR");
  public static readonly Currency BelarusianRouble   = new(code: "BYN");
  public static readonly Currency RussianRouble      = new(code: "RUB");
}

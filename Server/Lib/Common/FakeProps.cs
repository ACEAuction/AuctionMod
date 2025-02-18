﻿using ACE.Entity.Enum.Properties;

namespace ACE.Shared;

//https://github.com/aquafir/ACE.BaseMod/blob/master/ACE.Shared/FakeProperty.cs


//!!!!Very important to avoid using properties ACE or other Mods uses!!!!
public enum FakeBool
{
    None = 10000,
    IsCustomContainerOpen = 10001,
    IsAuctionTagging = 10002
}

public enum FakeDID
{

    None = 10000

}

public enum FakeFloat
{
    None = 10000,
    LastFailedListingTimestamp = 10001,
    ListingStartTimestamp = 10002,
    ListingEndTimestamp = 10003,
    BidTimestamp = 10004
}

public enum FakeIID
{
    None = 10000,
    BankId = 10001,
    ListingId = 10002,
    ListingOwnerId = 10003,
    BidOwnerId = 10004,
    SellerId = 10005,
    HighestBidderId = 10006
}

public enum FakeInt
{
    None = 10000,
    ListingStartPrice = 10001,
    ListingCurrencyType = 10002,
    ListingHighBid = 10003,
    BankItemCount = 10004,
    ListingBuyoutPrice = 10005
}

public enum FakeInt64
{
    None = 10000
}

public enum FakeString
{
    None = 10000,
    ListingStatus = 10001,
    HighestBidderName = 10002,
    SellerName = 10003
}

public static class FakePropertyHelper
{
    //public static void SetProperty(this WorldObject wo, FakePropertyInt64 property, long value) => wo.SetProperty(property.Prop(), value);
    public static void SetProperty(this WorldObject wo, FakeBool property, bool value) => wo.SetProperty(property.Prop(), value);
    public static void RemoveProperty(this WorldObject wo, FakeBool property) => wo.RemoveProperty(property.Prop());
    public static bool? GetProperty(this WorldObject wo, FakeBool property) => wo.GetProperty(property.Prop());
    public static void SetProperty(this WorldObject wo, FakeInt property, int value) => wo.SetProperty(property.Prop(), value);
    public static void RemoveProperty(this WorldObject wo, FakeInt property) => wo.RemoveProperty(property.Prop());
    public static int? GetProperty(this WorldObject wo, FakeInt property) => wo.GetProperty(property.Prop());
    public static void SetProperty(this WorldObject wo, FakeInt64 property, long value) => wo.SetProperty(property.Prop(), value);
    public static void RemoveProperty(this WorldObject wo, FakeInt64 property) => wo.RemoveProperty(property.Prop());
    public static long? GetProperty(this WorldObject wo, FakeInt64 property) => wo.GetProperty(property.Prop());
    public static void SetProperty(this WorldObject wo, FakeFloat property, double value) => wo.SetProperty(property.Prop(), value);
    public static void RemoveProperty(this WorldObject wo, FakeFloat property) => wo.RemoveProperty(property.Prop());
    public static double? GetProperty(this WorldObject wo, FakeFloat property) => wo.GetProperty(property.Prop());
    public static void SetProperty(this WorldObject wo, FakeString property, string value) => wo.SetProperty(property.Prop(), value);
    public static void RemoveProperty(this WorldObject wo, FakeString property) => wo.RemoveProperty(property.Prop());
    public static string? GetProperty(this WorldObject wo, FakeString property) => wo.GetProperty(property.Prop());
    public static void SetProperty(this WorldObject wo, FakeDID property, uint value) => wo.SetProperty(property.Prop(), value);
    public static void RemoveProperty(this WorldObject wo, FakeDID property) => wo.RemoveProperty(property.Prop());
    public static uint? GetProperty(this WorldObject wo, FakeDID property) => wo.GetProperty(property.Prop());
#if REALM
    public static void SetProperty(this WorldObject wo, FakeIID property, ulong value) => wo.SetProperty(property.Prop(), value);
#else
    public static void SetProperty(this WorldObject wo, FakeIID property, uint value) => wo.SetProperty(property.Prop(), value);
#endif
    public static void RemoveProperty(this WorldObject wo, FakeIID property) => wo.RemoveProperty(property.Prop());
#if REALM
    public static ulong? GetProperty(this WorldObject wo, FakeIID property) => wo.GetProperty(property.Prop());
#else
    public static uint? GetProperty(this WorldObject wo, FakeIID property) => wo.GetProperty(property.Prop());
#endif    
    public static PropertyBool Prop(this FakeBool prop) => (PropertyBool)prop;
    public static PropertyDataId Prop(this FakeDID prop) => (PropertyDataId)prop;
    public static PropertyFloat Prop(this FakeFloat prop) => (PropertyFloat)prop;
    public static PropertyInstanceId Prop(this FakeIID prop) => (PropertyInstanceId)prop;
    public static PropertyInt Prop(this FakeInt prop) => (PropertyInt)prop;
    public static PropertyInt64 Prop(this FakeInt64 prop) => (PropertyInt64)prop;
    public static PropertyString Prop(this FakeString prop) => (PropertyString)prop;
}


public enum CombinationStyle
{
    Additive,
    Multiplicative,
}

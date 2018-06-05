// Generated by ProtoGen, Version=2.4.1.555, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using System.Collections.Generic;
namespace PhoneNumbers {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Phonenumber {
  
    
    #region Static variables
    #endregion
    #region Extensions
    internal static readonly object Descriptor;
    static Phonenumber() {
      Descriptor = null;
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public partial class PhoneNumber {
    private PhoneNumber() { }
    private static readonly PhoneNumber defaultInstance = new PhoneNumber();
    private static readonly string[] _phoneNumberFieldNames = new string[] { "country_code", "country_code_source", "extension", "italian_leading_zero", "national_number", "number_of_leading_zeros", "preferred_domestic_carrier_code", "raw_input" };
    private static readonly uint[] _phoneNumberFieldTags = new uint[] { 8, 48, 26, 32, 16, 64, 58, 42 };
    public static PhoneNumber DefaultInstance {
      get { return defaultInstance; }
    }
    
    public PhoneNumber DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected PhoneNumber ThisMessage {
      get { return this; }
    }
    
    #region Nested types
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum CountryCodeSource {
        UNSPECIFIED = 0,
        FROM_NUMBER_WITH_PLUS_SIGN = 1,
        FROM_NUMBER_WITH_IDD = 5,
        FROM_NUMBER_WITHOUT_PLUS_SIGN = 10,
        FROM_DEFAULT_COUNTRY = 20,
      }
      
    }
    #endregion
    
    public const int CountryCodeFieldNumber = 1;
    private bool hasCountryCode;
    private int countryCode_;
    public bool HasCountryCode {
      get { return hasCountryCode; }
    }
    public int CountryCode {
      get { return countryCode_; }
    }
    
    public const int NationalNumberFieldNumber = 2;
    private bool hasNationalNumber;
    private ulong nationalNumber_;
    public bool HasNationalNumber {
      get { return hasNationalNumber; }
    }
    public ulong NationalNumber {
      get { return nationalNumber_; }
    }
    
    public const int ExtensionFieldNumber = 3;
    private bool hasExtension;
    private string extension_ = "";
    public bool HasExtension {
      get { return hasExtension; }
    }
    public string Extension {
      get { return extension_; }
    }
    
    public const int ItalianLeadingZeroFieldNumber = 4;
    private bool hasItalianLeadingZero;
    private bool italianLeadingZero_;
    public bool HasItalianLeadingZero {
      get { return hasItalianLeadingZero; }
    }
    public bool ItalianLeadingZero {
      get { return italianLeadingZero_; }
    }
    
    public const int NumberOfLeadingZerosFieldNumber = 8;
    private bool hasNumberOfLeadingZeros;
    private int numberOfLeadingZeros_ = 1;
    public bool HasNumberOfLeadingZeros {
      get { return hasNumberOfLeadingZeros; }
    }
    public int NumberOfLeadingZeros {
      get { return numberOfLeadingZeros_; }
    }
    
    public const int RawInputFieldNumber = 5;
    private bool hasRawInput;
    private string rawInput_ = "";
    public bool HasRawInput {
      get { return hasRawInput; }
    }
    public string RawInput {
      get { return rawInput_; }
    }
    
    public const int CountryCodeSourceFieldNumber = 6;
    private bool hasCountryCodeSource;
    private PhoneNumber.Types.CountryCodeSource countryCodeSource_ = PhoneNumber.Types.CountryCodeSource.UNSPECIFIED;
    public bool HasCountryCodeSource {
      get { return hasCountryCodeSource; }
    }
    public PhoneNumber.Types.CountryCodeSource CountryCodeSource {
      get { return countryCodeSource_; }
    }
    
    public const int PreferredDomesticCarrierCodeFieldNumber = 7;
    private bool hasPreferredDomesticCarrierCode;
    private string preferredDomesticCarrierCode_ = "";
    public bool HasPreferredDomesticCarrierCode {
      get { return hasPreferredDomesticCarrierCode; }
    }
    public string PreferredDomesticCarrierCode {
      get { return preferredDomesticCarrierCode_; }
    }
    
    public bool IsInitialized {
      get {
        if (!hasCountryCode) return false;
        if (!hasNationalNumber) return false;
        return true;
      }
    }
    
    
    
    
    #region Lite runtime methods
    public override int GetHashCode() {
      int hash = GetType().GetHashCode();
      if (hasCountryCode) hash ^= countryCode_.GetHashCode();
      if (hasNationalNumber) hash ^= nationalNumber_.GetHashCode();
      if (hasExtension) hash ^= extension_.GetHashCode();
      if (hasItalianLeadingZero) hash ^= italianLeadingZero_.GetHashCode();
      if (hasNumberOfLeadingZeros) hash ^= numberOfLeadingZeros_.GetHashCode();
      if (hasRawInput) hash ^= rawInput_.GetHashCode();
      if (hasCountryCodeSource) hash ^= countryCodeSource_.GetHashCode();
      if (hasPreferredDomesticCarrierCode) hash ^= preferredDomesticCarrierCode_.GetHashCode();
      return hash;
    }
    
    public override bool Equals(object obj) {
      PhoneNumber other = obj as PhoneNumber;
      if (other == null) return false;
      if (hasCountryCode != other.hasCountryCode || (hasCountryCode && !countryCode_.Equals(other.countryCode_))) return false;
      if (hasNationalNumber != other.hasNationalNumber || (hasNationalNumber && !nationalNumber_.Equals(other.nationalNumber_))) return false;
      if (hasExtension != other.hasExtension || (hasExtension && !extension_.Equals(other.extension_))) return false;
      if (hasItalianLeadingZero != other.hasItalianLeadingZero || (hasItalianLeadingZero && !italianLeadingZero_.Equals(other.italianLeadingZero_))) return false;
      if (hasNumberOfLeadingZeros != other.hasNumberOfLeadingZeros || (hasNumberOfLeadingZeros && !numberOfLeadingZeros_.Equals(other.numberOfLeadingZeros_))) return false;
      if (hasRawInput != other.hasRawInput || (hasRawInput && !rawInput_.Equals(other.rawInput_))) return false;
      if (hasCountryCodeSource != other.hasCountryCodeSource || (hasCountryCodeSource && !countryCodeSource_.Equals(other.countryCodeSource_))) return false;
      if (hasPreferredDomesticCarrierCode != other.hasPreferredDomesticCarrierCode || (hasPreferredDomesticCarrierCode && !preferredDomesticCarrierCode_.Equals(other.preferredDomesticCarrierCode_))) return false;
      return true;
    }
    
    #endregion
    
    
    public static Builder CreateBuilder() { return new Builder(); }
    public Builder ToBuilder() { return CreateBuilder(this); }
    public Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(PhoneNumber prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Builder {
      protected Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(PhoneNumber cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private PhoneNumber result;
      
      private PhoneNumber PrepareBuilder() {
        if (resultIsReadOnly) {
          PhoneNumber original = result;
          result = new PhoneNumber();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected PhoneNumber MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public PhoneNumber DefaultInstanceForType {
        get { return PhoneNumber.DefaultInstance; }
      }
      
      public PhoneNumber Build() { return BuildPartial(); }
      
      public PhoneNumber BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result;
      }
      
      
      public Builder MergeFrom(PhoneNumber other) {
        if (other == PhoneNumber.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasCountryCode) {
          CountryCode = other.CountryCode;
        }
        if (other.HasNationalNumber) {
          NationalNumber = other.NationalNumber;
        }
        if (other.HasExtension) {
          Extension = other.Extension;
        }
        if (other.HasItalianLeadingZero) {
          ItalianLeadingZero = other.ItalianLeadingZero;
        }
        if (other.HasNumberOfLeadingZeros) {
          NumberOfLeadingZeros = other.NumberOfLeadingZeros;
        }
        if (other.HasRawInput) {
          RawInput = other.RawInput;
        }
        if (other.HasCountryCodeSource) {
          CountryCodeSource = other.CountryCodeSource;
        }
        if (other.HasPreferredDomesticCarrierCode) {
          PreferredDomesticCarrierCode = other.PreferredDomesticCarrierCode;
        }
        return this;
      }
      
      
      
      
      public bool HasCountryCode {
        get { return result.hasCountryCode; }
      }
      public int CountryCode {
        get { return result.CountryCode; }
        set { SetCountryCode(value); }
      }
      public Builder SetCountryCode(int value) {
        PrepareBuilder();
        result.hasCountryCode = true;
        result.countryCode_ = value;
        return this;
      }
      public Builder ClearCountryCode() {
        PrepareBuilder();
        result.hasCountryCode = false;
        result.countryCode_ = 0;
        return this;
      }
      
      public bool HasNationalNumber {
        get { return result.hasNationalNumber; }
      }
      public ulong NationalNumber {
        get { return result.NationalNumber; }
        set { SetNationalNumber(value); }
      }
      public Builder SetNationalNumber(ulong value) {
        PrepareBuilder();
        result.hasNationalNumber = true;
        result.nationalNumber_ = value;
        return this;
      }
      public Builder ClearNationalNumber() {
        PrepareBuilder();
        result.hasNationalNumber = false;
        result.nationalNumber_ = 0UL;
        return this;
      }
      
      public bool HasExtension {
        get { return result.hasExtension; }
      }
      public string Extension {
        get { return result.Extension; }
        set { SetExtension(value); }
      }
      public Builder SetExtension(string value) {
        if(value == null) throw new global::System.ArgumentNullException("value");
        PrepareBuilder();
        result.hasExtension = true;
        result.extension_ = value;
        return this;
      }
      public Builder ClearExtension() {
        PrepareBuilder();
        result.hasExtension = false;
        result.extension_ = "";
        return this;
      }
      
      public bool HasItalianLeadingZero {
        get { return result.hasItalianLeadingZero; }
      }
      public bool ItalianLeadingZero {
        get { return result.ItalianLeadingZero; }
        set { SetItalianLeadingZero(value); }
      }
      public Builder SetItalianLeadingZero(bool value) {
        PrepareBuilder();
        result.hasItalianLeadingZero = true;
        result.italianLeadingZero_ = value;
        return this;
      }
      public Builder ClearItalianLeadingZero() {
        PrepareBuilder();
        result.hasItalianLeadingZero = false;
        result.italianLeadingZero_ = false;
        return this;
      }
      
      public bool HasNumberOfLeadingZeros {
        get { return result.hasNumberOfLeadingZeros; }
      }
      public int NumberOfLeadingZeros {
        get { return result.NumberOfLeadingZeros; }
        set { SetNumberOfLeadingZeros(value); }
      }
      public Builder SetNumberOfLeadingZeros(int value) {
        PrepareBuilder();
        result.hasNumberOfLeadingZeros = true;
        result.numberOfLeadingZeros_ = value;
        return this;
      }
      public Builder ClearNumberOfLeadingZeros() {
        PrepareBuilder();
        result.hasNumberOfLeadingZeros = false;
        result.numberOfLeadingZeros_ = 1;
        return this;
      }
      
      public bool HasRawInput {
        get { return result.hasRawInput; }
      }
      public string RawInput {
        get { return result.RawInput; }
        set { SetRawInput(value); }
      }
      public Builder SetRawInput(string value) {
        if(value == null) throw new global::System.ArgumentNullException("value");
        PrepareBuilder();
        result.hasRawInput = true;
        result.rawInput_ = value;
        return this;
      }
      public Builder ClearRawInput() {
        PrepareBuilder();
        result.hasRawInput = false;
        result.rawInput_ = "";
        return this;
      }
      
      public bool HasCountryCodeSource {
       get { return result.hasCountryCodeSource; }
      }
      public PhoneNumber.Types.CountryCodeSource CountryCodeSource {
        get { return result.CountryCodeSource; }
        set { SetCountryCodeSource(value); }
      }
      public Builder SetCountryCodeSource(PhoneNumber.Types.CountryCodeSource value) {
        PrepareBuilder();
        result.hasCountryCodeSource = true;
        result.countryCodeSource_ = value;
        return this;
      }
      public Builder ClearCountryCodeSource() {
        PrepareBuilder();
        result.hasCountryCodeSource = false;
        result.countryCodeSource_ = PhoneNumber.Types.CountryCodeSource.UNSPECIFIED;
        return this;
      }
      
      public bool HasPreferredDomesticCarrierCode {
        get { return result.hasPreferredDomesticCarrierCode; }
      }
      public string PreferredDomesticCarrierCode {
        get { return result.PreferredDomesticCarrierCode; }
        set { SetPreferredDomesticCarrierCode(value); }
      }
      public Builder SetPreferredDomesticCarrierCode(string value) {
        if(value == null) throw new global::System.ArgumentNullException("value");
        PrepareBuilder();
        result.hasPreferredDomesticCarrierCode = true;
        result.preferredDomesticCarrierCode_ = value;
        return this;
      }
      public Builder ClearPreferredDomesticCarrierCode() {
        PrepareBuilder();
        result.hasPreferredDomesticCarrierCode = false;
        result.preferredDomesticCarrierCode_ = "";
        return this;
      }
    }
    static PhoneNumber() {
      object.ReferenceEquals(Phonenumber.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code

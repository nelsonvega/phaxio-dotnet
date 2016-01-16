﻿# Phaxio (ALPHA) (NO LICENSE)

Phaxio is the only cloud based fax API designed for developers. This is the .NET client library for Phaxio.

## Getting started

First, [sign up](https://www.phaxio.com/signup) if you haven't already.

Then, go to [api settings](https://www.phaxio.com/apiSettings) and get your key and your secret.

The Phaxio class is the entry point for any Phaxio operation. 

    var phaxio = new Phaxio(key, secret);

## Getting your account status

    var account = phaxio.GetAccountStatus();
    Console.WriteLine(string.Format("Balance: {0}", account.Balance));

## Getting area codes 

If you want to know what area codes are available for purchase, you can call this method:

    Dictionary<string, CityState> areaCodes = phaxio.GetAreaCodes();
    
This returns a Dictionary with the area codes as keys, and a CityState object that has the city and state of
the area code. You can also optionally request tollfree numbers:

    Dictionary<string, CityState> areaCodes = phaxio.GetAreaCodes(tollFree:true);

You can specifiy the state:

    Dictionary<string, CityState> areaCodes = phaxio.GetAreaCodes(state:"MA");

Or both:

    Dictionary<string, CityState> areaCodes = phaxio.GetAreaCodes(tollFree:true, state:"MA");
    
## Cancelling a fax

You can cancel a fax by id:

    bool success = phaxio.CancelFax(123);

It returns a bool saying whether the operation was successful or not.

## Resending a fax

You can resend a fax by id:

    bool success = phaxio.ResendFax(123);

It returns a bool saying whether the operation was successful or not.

## Deleting a fax

You can delete a fax by id:

    bool success = phaxio.DeleteFax(123);

It returns a bool saying whether the operation was successful or not. You can also specify whether to only delete the files (default is false):

    bool success = phaxio.DeleteFax(123, true);

## Listing your numbers

To get a list of your numbers, you can run this method:

    var numbers = phaxio.ListNumbers();

which will return a List with all of your numbers.

You can specify an area code to search in:

    var numbers = phaxio.ListNumbers("808");

or you can search for a specific number:
    
    var numbers = phaxio.ListNumbers(number: "8088675309");
    
## Provisioning a number

You can ask Phaxio to get you a new number (you must specify an area code:

    var newNumber = phaxio.ProvisionNumber("808");

The call returns a PhoneNumber object representing your new number.

You can also specify a callback URL that will be called when a fax is recieved that overrides the default callback URL.

    var newNumber = phaxio.ProvisionNumber("808", "https://example.com/callback");
    
## Release number

You can a number:

    bool success = phaxio.ReleaseNumber("8088675309");

It returns a bool saying whether the operation was successful or not.
    
## Getting supported countries

If you want to know what countries are supported by Phaxio, you can call this method:

    Dictionary<string, CityState> areaCodes = phaxio.GetAreaCodes();
    
This returns a Dictionary with the country names as keys, and a Pricing object that has the price per page.

## Creating a PhaxCode

Creating a PhaxCode is simple:

    var code = phaxio.CreatePhaxCode();
    
Code is a Url object where you can download the barcode.

You can also attach metadata to the code:

    var code = phaxio.CreatePhaxCode("{'key':'value'}");

You can also get the image directly:

    var code = phaxio.DownloadPhaxCodePng();
    
    File.WriteAllBytes(@"C:\temp\phaxCode.png", code);
    
This returns a byte array representing the barcode. You can attach metadata to the code, same as above:

    var code = phaxio.DownloadPhaxCodePng("{'key':'value'}");
    
&copy; 2016 Noel Herrick
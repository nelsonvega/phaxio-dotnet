﻿# Phaxio (ALPHA) (NO LICENSE)

Phaxio is the only cloud based fax API designed for developers. This is the .NET client library for Phaxio.

## Getting started

First, [sign up](https://www.phaxio.com/signup) if you haven't already.

Second, go to [api settings](https://www.phaxio.com/apiSettings) and get your key and your secret.

If you're a C# developer, [see here](Docs/README-csharp.md) for basic usage.

If you're a VB.NET developer, [see here](Docs/README-vb.md) for basic usage.

## Errors

Sometimes errors will occur, whether it's network timeouts or bad requests. All operations will throw an
exception if a network or client error occurs. Some operations return data to you, such as a byte array
representing a PDF. If those requests fail due to an authentication failure, a malformed number, insufficient
funds, or rate limiting, they'll throw an ApplicationException with an error message describing the problem.

For those requests returning a Result object, that will have a bool named Success and a string called
Message that will tell you the result of the operation.

### Rate limiting

The Phaxio API is rate limited. If you make too many requests too quickly, you might receive this error.
Check the exception message, wait a second, and then try your request again.

## Writing callbacks (webhooks)

[Read this](Docs/README-callbacks.md)

&copy; 2016 Noel Herrick
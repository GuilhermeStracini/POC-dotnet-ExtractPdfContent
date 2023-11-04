# PoC .NET - Extract PDF content

🔬 Proof of Concept of extracting content from PDF files using multiple PDF libraries.

[![wakatime](https://wakatime.com/badge/github/GuilhermeStracini/POC-dotnet-ExtractPdfContent.svg)](https://wakatime.com/badge/github/GuilhermeStracini/POC-dotnet-ExtractPdfContent)
[![Maintainability](https://api.codeclimate.com/v1/badges/0473f6981139c13f8820/maintainability)](https://codeclimate.com/github/GuilhermeStracini/POC-dotnet-ExtractPdfContent/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/0473f6981139c13f8820/test_coverage)](https://codeclimate.com/github/GuilhermeStracini/POC-dotnet-ExtractPdfContent/test_coverage)
[![CodeFactor](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-dotnet-ExtractPdfContent/badge)](https://www.codefactor.io/repository/github/GuilhermeStracini/POC-dotnet-ExtractPdfContent)
[![GitHub license](https://img.shields.io/github/license/GuilhermeStracini/POC-dotnet-ExtractPdfContent)](https://github.com/GuilhermeStracini/POC-dotnet-ExtractPdfContent)
[![GitHub last commit](https://img.shields.io/github/last-commit/GuilhermeStracini/POC-dotnet-ExtractPdfContent)](https://github.com/GuilhermeStracini/POC-dotnet-ExtractPdfContent)
[![Deploy via ftp](https://github.com/GuilhermeStracini/POC-dotnet-ExtractPdfContent/actions/workflows/build.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-dotnet-ExtractPdfContent/actions/workflows/build.yml)
[![PHP Linting](https://github.com/GuilhermeStracini/POC-dotnet-ExtractPdfContent/actions/workflows/linter.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-dotnet-ExtractPdfContent/actions/workflows/linter.yml)

Libraries to use:

- [docnet](https://github.com/GowenGit/docnet)
- [iTextSharp.LGPLv2.Core](https://github.com/VahidN/iTextSharp.LGPLv2.Core)
- [PdfPig](https://github.com/UglyToad/PdfPig/)
- ~~[PdfSharpCore](https://github.com/ststeiger/PdfSharpCore)~~ **This library doesn't support extract text yet**

Refer to this article: [Reading a PDF in C# on .NET Core](https://dev.to/eliotjones/reading-a-pdf-in-c-on-net-core-43ef)

The main goal of this POC is to test the available options we have now to read effectively content from PDF files and replace the current [iTextSharp - for .NET Framework](https://www.nuget.org/packages/iTextSharp).

---

## Results

### DocNet

So far is the best

### iTextSharp

Looks good

### PdfPig

Some pitfalls to be addressed
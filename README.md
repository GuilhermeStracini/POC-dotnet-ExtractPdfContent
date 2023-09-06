# PoC .NET - Extract PDF content

[![wakatime](https://wakatime.com/badge/github/GuilhermeStracini/POC-dotnet-ExtractPdfContent.svg)](https://wakatime.com/badge/github/GuilhermeStracini/POC-dotnet-ExtractPdfContent)
[![Deploy via ftp](https://github.com/GuilhermeStracini/POC-dotnet-ExtractPdfContent/actions/workflows/build.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-dotnet-ExtractPdfContent/actions/workflows/build.yml)
[![PHP Linting](https://github.com/GuilhermeStracini/POC-dotnet-ExtractPdfContent/actions/workflows/linter.yml/badge.svg)](https://github.com/GuilhermeStracini/POC-dotnet-ExtractPdfContent/actions/workflows/linter.yml)

🔬 Proof of Concept of extracting content from PDF files using multiple PDF libraries.

Libraries to use:

- [iTextSharp.LGPLv2.Core](https://github.com/VahidN/iTextSharp.LGPLv2.Core)
- [PdfPig](https://github.com/UglyToad/PdfPig/)
- [docnet](https://github.com/GowenGit/docnet)
- [PdfSharpCore](https://github.com/ststeiger/PdfSharpCore)

Refer to this article: [Reading a PDF in C# on .NET Core](https://dev.to/eliotjones/reading-a-pdf-in-c-on-net-core-43ef)

The main goal of this POC is to test the available options we have now to read effectively content from PDF files and replace the current [iTextSharp - for .NET Framework](https://www.nuget.org/packages/iTextSharp).

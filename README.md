# Point proposer for Indexer - sample project

This is a sample project of a point proposer for the Indexer application.

The Indexer application and this sample project was worked on
during Team Project course at Gdańsk University of Technology.

## Building

**.NET SDK 7.0 required**

This project can be built with the command:
```
dotnet build
```
Alternatively, you can open the solution file (`PointProposer.sln`) in Visual Studio 2022
and run the build from there.

After the build is finished, its output can be found
in `artifacts/bin/PointProposer/Debug` directory.

## Building for deployment

This project can be built for deployment with the command:
```
dotnet publish -c Release
```
After the build is finished, the application file is available
at `artifacts/publish/PointProposer/Release/PointProposer.exe`.

## License

Distributed under the MIT License. See `LICENSE` for more information.

---

> Mikołaj Morozowski &nbsp;&middot;&nbsp;
> GitHub [@themix240](https://github.com/themix240)<br>
> Jakub Kuczys &nbsp;&middot;&nbsp;
> GitHub [@Jackenmen](https://github.com/Jackenmen)<br>

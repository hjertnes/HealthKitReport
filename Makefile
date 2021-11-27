clean:
	dotnet clean
build:
	cd HealthKitReport && dotnet publish -c release
install:
	cp HealthKitReport/bin/Release/net6.0/osx-x64/publish/HealthKitReport ~/bin/healthkitreport

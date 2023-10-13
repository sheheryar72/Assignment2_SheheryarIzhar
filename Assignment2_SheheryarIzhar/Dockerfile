# Build Stage

# Set the base image to the official Microsoft .NET Core SDK image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the project file(s) and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code files
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Serve Stage

# Set the base image to the official Microsoft .NET Core Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime

# Set the working directory inside the container
WORKDIR /app

# Copy the published application from the build stage
COPY --from=build /app/out .

# Expose the desired port(s) for the application
EXPOSE 80

# Set the entry point for the application
ENTRYPOINT ["dotnet", "Assignment2_SheheryarIzhar.dll"]




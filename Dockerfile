# ------------------------------------------------------------------------------
# The applicaiton will be in this first stage called 'build'
# ------------------------------------------------------------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

ARG BUILD_CONFIGURATION=Release

# Set the working directory inside the docker image
WORKDIR /src

# Copy the project file and restore the dependencies
COPY NascarCalendar.csproj .
RUN dotnet restore NascarCalendar.csproj

# Copy all our other files and build the application
COPY . .

# Build the application
RUN dotnet build NascarCalendar.csproj -c $BUILD_CONFIGURATION -o /app/build

# ------------------------------------------------------------------------------
# This stage is used to publish the application
# ------------------------------------------------------------------------------
FROM build as publish

ARG BUILD_CONFIGURATION=Release

# Publish the application
RUN dotnet publish NascarCalendar.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# ------------------------------------------------------------------------------
# The final stage will be used to run the application
# ------------------------------------------------------------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

# Change the working directory inside the docker imag
WORKDIR /app

# Expose these ports
EXPOSE 8080
EXPOSE 8081

# Copy the published application from the publish stage into this stage
COPY --from=publish /app/publish .

# This defines the command that will run when the container starts
ENTRYPOINT ["dotnet", "NascarCalendar.dll"]
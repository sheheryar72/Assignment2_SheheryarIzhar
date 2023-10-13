# Stop and remove any existing Docker container
docker stop your-container-name || true
docker rm your-container-name || true

# Build the Docker image
docker build -t assignment2_image .

# Run a new Docker container with the updated image
docker run -d -p 8070:8070 --name assignment2_container assignment2_image

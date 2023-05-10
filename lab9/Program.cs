using Lab9;

var youTubeUploader = new YouTubeUploader(clientId: "test-client-id", clientSecret: "test-client-secret");
youTubeUploader.Upload("D://Videos/Cats.mp4");
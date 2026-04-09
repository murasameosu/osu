// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Game.Online
{
    public class DevelopmentEndpointConfiguration : EndpointConfiguration
    {
        public DevelopmentEndpointConfiguration()
        {
            WebsiteUrl = @"http://localhost:5173";
            APIUrl = @"https://lazer.murasame.local";
            APIClientSecret = @"3LP2mhUrV89xxzD1YKNndXHEhWWCRLPNKioZ9ymT";
            APIClientID = "5";
            AvatarUrl = @"https://a.murasame.local";
            SpectatorUrl = "https://spectator.murasame.local/spectator";
            MultiplayerUrl = "https://spectator.murasame.local/multiplayer";
            MetadataUrl = "https://spectator.murasame.local/metadata";
            BeatmapSubmissionServiceUrl = $@"{APIUrl}/beatmap-submission";
        }
    }
}

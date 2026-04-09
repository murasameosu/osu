// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Game.Online
{
    public class ProductionEndpointConfiguration : EndpointConfiguration
    {
        public ProductionEndpointConfiguration()
        {
            WebsiteUrl = @"https://www.murasame.app";
            APIUrl = @"https://lazer.murasame.app";
            APIClientSecret = @"3LP2mhUrV89xxzD1YKNndXHEhWWCRLPNKioZ9ymT";
            APIClientID = "5";
            AvatarUrl = @"https://a.murasame.app";
            SpectatorUrl = "https://spectator.murasame.app/spectator";
            MultiplayerUrl = "https://spectator.murasame.app/multiplayer";
            MetadataUrl = "https://spectator.murasame.app/metadata";
            BeatmapSubmissionServiceUrl = $@"{APIUrl}/beatmap-submission";
        }
    }
}

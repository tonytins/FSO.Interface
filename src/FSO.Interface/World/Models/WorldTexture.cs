/*
 * This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
 * If a copy of the MPL was not distributed with this file, You can obtain one at
 * http://mozilla.org/MPL/2.0/.
 */

using Microsoft.Xna.Framework.Graphics;

namespace FSO.Interface.World.Models
{
    /// <summary>
    /// A texture used in the game world.
    /// </summary>
    public record WorldTexture(Texture2D Pixel, Texture2D ZBuffer);
}

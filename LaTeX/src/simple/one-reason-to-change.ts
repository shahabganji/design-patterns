/* 
 * This is NOT single responsibility.
 * There are several responsibilities here: 
 * 
 * 1. preparing the raised bed before planting
 * 2. maintaining it after planting
 * 3. harvesting
 * 
 * It's likely that our watering system will change 
 * independently of our harvesting system.
 */

class RaisedBed {

    public addCompost() { }

    public addMulch() { }

    public addSeeds() { }

    public addWater() { }

    public harvestProduce() { }

    public pullWeeds() { }
}

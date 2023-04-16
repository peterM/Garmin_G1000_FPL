# MalikP. Aviation - Garmin G1000 FPL
Object model to create Garmin G1000 Flight Plan files

There are at least 2 versions of schema. For now this project supports `v1` and `v2`.
There are not lot of differences between `version 1` and `version 2`.

## How to use

**RISK NOTICE: YOU ARE DOING IT ALL ON YOUR OWN RISK. WE ARE NOT RESPONSIBLE IN CASE YOUR ACTIONS WILL DAMAGE YOUR AVIONICS. WHEN YOU ARE NOT SURE JUST STOP AND DO NOT CONTINUE** 

```
Importing a Flight Plan from an SD Card:

1) Insert the SD card containing the flight plan in the top card slot on the MFD.
2) Press the FPL Key to display the Active Flight Plan Page on the MFD.
3) Turn the small FMS Knob to select the Flight Plan Catalog Page.
4) Press the FMS Knob to activate the cursor.
5) Turn either FMS Knob to highlight an empty or existing flight plan.
6) Press the IMPORT Softkey; or press the MENU Key, select “Import Flight Plan”, and press the ENT Key.
If an empty slot is selected, a list of the available flight plans on the SD card will be displayed.
Or:
If an existing flight plan is selected, an “Overwrite existing flight plan? OK or CANCEL” prompt is displayed.
Press the ENT Key to choose to overwrite the selected flight plan and see the list of available flight plans on the
SD card. If overwriting the existing flight plan is not desired, select “CANCEL” using the FMS Knob, press the
ENT Key, select another flight plan slot, and press the IMPORT Softkey again.
7) Turn the small FMS Knob to highlight the desired flight plan for importing.
8 ) Press the ENT Key to initiate the import.
9) Press the ENT Key again to confirm the import.
```

#### Flight plan file Extension

File extension should be `*.fpl`. Therefore when you saving generated file use extension `*.fpl`


#### `Version 1` Example:

```xml
<flight-plan xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://www8.garmin.com/xmlschemas/FlightPlan/v1">
  <file-description>My Test FPL</file-description>
  <author>
    <author-name>Peter Mrkvicka</author-name>
    <email id="myMail" domain="email.com" />
  </author>
  <created>2023-04-15T22:20:14.9860472Z</created>
  <waypoint-table>
    <waypoint>
      <identifier>LZIB</identifier>
      <type>AIRPORT</type>
      <country-code>LZ</country-code>
      <lat>48.170200</lat>
      <lon>17.212700</lon>
      <comment>BRATISLAVA</comment>
      <elevation>436</elevation>
      <waypoint-description>LZIB - Bratislava</waypoint-description>
    </waypoint>
    <waypoint>
      <identifier>NIT</identifier>
      <type>VOR</type>
      <country-code>LZ</country-code>
      <lat>48.290401</lat>
      <lon>18.050600</lon>
      <comment>NITRA VOR/DME</comment>
      <elevation>810</elevation>
      <waypoint-description>NIT - NITRA</waypoint-description>
    </waypoint>
    <waypoint>
      <identifier>SLC</identifier>
      <type>VOR</type>
      <country-code>LZ</country-code>
      <lat>48.453201</lat>
      <lon>19.115900</lon>
      <comment>SLIAC VOR/DME</comment>
      <elevation>1670</elevation>
      <waypoint-description>SLC - SLIAC</waypoint-description>
    </waypoint>
    <waypoint>
      <identifier>KSC</identifier>
      <type>VOR</type>
      <country-code>LZ</country-code>
      <lat>48.683102</lat>
      <lon>21.248199</lon>
      <comment>KOSICE VOR/DME</comment>
      <elevation>787</elevation>
      <waypoint-description>KSC - KOSICE</waypoint-description>
    </waypoint>
    <waypoint>
      <identifier>LZKZ</identifier>
      <type>AIRPORT</type>
      <country-code>LZ</country-code>
      <lat>48.663101</lat>
      <lon>21.241100</lon>
      <comment>KOSICE</comment>
      <elevation>755</elevation>
      <waypoint-description>LZKZ - KOSICE</waypoint-description>
    </waypoint>
  </waypoint-table>
  <route>
    <route-name>LZIB/LZKZ</route-name>
    <route-description>Bratislava - Kosice</route-description>
    <flight-plan-index>1</flight-plan-index>
    <route-point>
      <waypoint-identifier>LZIB</waypoint-identifier>
      <waypoint-type>AIRPORT</waypoint-type>
      <waypoint-country-code>LZ</waypoint-country-code>
    </route-point>
    <route-point>
      <waypoint-identifier>NIT</waypoint-identifier>
      <waypoint-type>VOR</waypoint-type>
      <waypoint-country-code>LZ</waypoint-country-code>
    </route-point>
    <route-point>
      <waypoint-identifier>SLC</waypoint-identifier>
      <waypoint-type>VOR</waypoint-type>
      <waypoint-country-code>LZ</waypoint-country-code>
    </route-point>
    <route-point>
      <waypoint-identifier>KSC</waypoint-identifier>
      <waypoint-type>VOR</waypoint-type>
      <waypoint-country-code>LZ</waypoint-country-code>
    </route-point>
    <route-point>
      <waypoint-identifier>LZKZ</waypoint-identifier>
      <waypoint-type>AIRPORT</waypoint-type>
      <waypoint-country-code>LZ</waypoint-country-code>
    </route-point>
  </route>
</flight-plan>
```

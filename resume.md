
[Dan Edens](https://github.com/DanEdens)  

[(469)-636-7704](4696367704)  

[DanEdens31@gmail.com](DanEdens31@gmail.com)  

<center>Skills Summary  </center>  

---
Self Sufficient and Driven Software Engineer with a focus on Process Automation and Data Collection. 
Offering a wide range of experience in Project management, Data collection, Risk mitigation, and Compliance documentation.  

Hands-on field experience spent ensuring data flow from sensors and assisting clients with data utilisation, yielded a strong practical sense for user-centred Design.  

Incomprehensive list of tools I have delivered products using:  
- Python, NodeJS, Javascript, Java, Visual Basic, HTML, REST, PHP, SQL, MQTT, and a variety of APIs  
- Cloud platforms including Azure, AWS, and self-hosted services  
- DevOps CI/CD, Containerization, and Documentation generation  


# Work History  
## Geo-Instruments  
> 06/2018 - Present (07/2022)   
[Project Portfollio](/Portfollio.md)  
> [VIdeo detailing what we do at Geo-instruments](https://www.geo-instruments.com/implementing-geotechnical-monitoring-programs/)  

Geotechnical Monitoring specialist responsible for managing projects including Data collection, Web development, Risk mitigation and Compliance documentation for a variety of industries.  

- Experienced Operating Independently, and worked as a stand-alone remote branch for 3.5 years.  
- Managed multiple projects with job sites across the Midwest.  
- Built backends for data collection and set up project Websites using Python, Javascript, NodeJS, MQTT, SQL, and PHP.  
- Developed tools to improve efficiency and Issue response time.  
- Experience with Data acquisition tools such as Solar controllers, Modems, Sensors, and dataloggers.  

In addition to this Project management role, I heavily engaged myself in our Apps and Software departments.  

Some of these duties include:  
1. Setting up Customer websites  
1. Automating data collection of field sensors  
1. Alert Investigation  
1. Setting up and maintaining reports to clients  

  
<!-- • Certifications: 
> Osha10, Twic, TSAprecheck, Keolis ROW, E-railSafe, BNSF contractor  -->
<!-- [E-railSafe](https://erailsafe.com/usa/), [BNSF contractor card](assets/BNSF%20Contractor%20Card.jpg)  -->

<!-- # Portfolio:   -->

---
# Tools for Project Management  
1. Sitecheck Scanner  
    - [Check it out on Github](https://github.com/DanEdens/sitecheck)  
    - [Demo On Youtube](https://www.youtube.com/watch?v=HExwe__eeJU)    
    - [pip install sitecheck](https://pypi.org/project/sitecheck/0.8.1.1/)  
        [![IMAGE ALT TEXT](assets/ExampleSitecheckScannerTeamsCardGeneration.jpg)](http://www.youtube.com/watch?v=HExwe__eeJU "Video Title")  
    
    - A guided visual tour of project websites.  
    - Automated Browser used for detecting setup errors, missed readings, and anomalous data.  
    - Navigates through projects and highlights changes in sensor status.  
    - CLI for end-to-end testing project websites.  
    - Posts results to the company Team's channels.  
    <!-- - Written originally in Nodejs then migrated to python for the Apps team's benefit.   -->  
    <!-- - Geo-Instrument's Project managers and Apps team, used pull information on missing sensor data.   -->
    - Assists Geo-Instrument's field techs with keeping an eye on multiple projects while working in the field.  
    - SQL database is checked and any sensors missing longer than 22 hours are reported to an MQTT broker.  
    - Reduces load on the server for project checks, and prevents missed issues when working with sensors on very congested plan views.  
    - Results customizable for each project manager  

1. Timelapse_factory  
    - [Demo On Youtube](https://www.youtube.com/watch?v=cgKvyPWVw6E)  
 
    - NodeJS Web scrapper for pulling plots of data graphed on our Quickview platform.
     ![Example GIf](assets/RiversideExcavation35speedReduceColorTable.gif)
    - Used to overlay data from sensors installed in the Diaphragm wall onto Jobsite Camera footage.  

---   
# Tools for the Field  
1. Interface Panel -  
    [Download on Taskernet](https://taskernet.com/shares/?user=AS35m8mBhJAezDTr0Lio7dopdLiBaKgozAOxoCXM7Mh8sS5hSvSst1kEMf5%2FJeJveB%2BsvU8%3D&id=Project%3AInterface)  
    - GUI for assigning scripts to Mobile device triggers such as Shake, Hardware buttons, NFC tags, and Voice commands.  
     ![ExampleImage](assets/InterfacePanelExample_Tasker.jpg)  
    - Used to assist in safely operating testing equipment in Industrial environments.  
    - Able to detect current job by closest address, and uses this for sorting data.  
    - "SOS button" mode to alert On-Site Safety Manager  

1. LnetFieldApp  
    Frontend:   
    - Andriod App for controling [Topcon](https://www.topconpositioning.com/total-stations/robotic-total-stations/ms-axii) total stations.  
    ![LnetExample](assets/Lnet_example_Tasker.jpg)
    - Internal-use replacement for Campbell Scientic's [Loggerlink](https://play.google.com/store/apps/details?id=com.campbellsci.loggerlink&hl=en_US&gl=US) app.  
    - Significantly improved ability to zero in on survey points.  
  
-  
    Backend:  
    ![LnetExample](assets/LnetAppWithServerExample.jpg)
     - Lightweight and scalable python script that pipes MQTT topics into [Xargs](https://www.man7.org/linux/man-pages/man1/xargs.1.html).  
     - Non-blocking control of several Units through the [Loggernet CLI, Corascript](https://www.campbellsci.com/loggernet).  
     - Server utilizes Python, Xargs, and Mosquitto.  
---

# Tools for the Shop  
1. AMTSworkshop  
    *Began as migration of 20 years worth of Campbell Scientific Datalogger programs into Git.*  
    ![AMTScover](assets/AMTSworkshopCover.jpg)  
    - Worked on an R&D project for a new type of Monitoring prism.  
    - Azure DevOps pipelines for testing each commit on live lab equipment  
    - Designed to handle rolling out changes slowly due to certain project specs requiring legacy versions on remote data loggers.  
    
1. Geo Battery Bot  
    [Check it out on Github](https://github.com/DanEdens/GeoBatteryBot_public)  
    ![Batterybotexample](assets/BatteryBotExample.jpg)  
    ![Batterybotexample](assets/BatteryBotGUIexample.jpg)  
    Mobile app for tracking inventory of Geo-instrument's fleet of 110ah AGM batteries.  
    This is used to manage the [desulfating](https://www.upsbatterycenter.com/blog/battery-desulfation/) schedule.  
    
    - I created a QRcode generator which publishes a number and status to the (Join API)[https://joaoapps.com/join/api/].  
    - A tablet located in the Geo-Instrument's Shop acts as the server.  
    - Created an Andriod app as GUI and backend to log unit events.  
    - Stickers are generated in a given range of serial numbers by the [python script: QR-generator.py](https://github.com/DanEdens/GeoBatteryBot_public/blob/master/qr-generator.py)  
---

## Chili's Grill and Bar  
> 4570 TX-121, Lewisville, TX 75056 - (214) 494-6341  
> Prep Cook: 01/2016 to 06/2018  
1. Motivated food industry worker offering over 5 years of experience.  
1. Lead Prep team, Maintained a show-ready kitchen for Chili's Test location  
1. Took part in Franchise showcases and assisted in Marketing events such as filming TV commercials.  
1. Worked closely with corporate offices to help field test timely and effective ways to improve menu recipes and standards.  
1. Created a hands-free Recipe app for the kitchen's tablet.  
1. Created Cooling log and Inventory tracking app.  
1. Collected data on the accuracy of daily On-hand food quantities for a 6-month period. This Resulted in Improved Daily prep list efficiency.  
  
---
  
## Chili's Grill and Bar  
> 190 Williamson Blvd, Ormond Beach, FL 32174 - (386) 672-7760  
> Prep Cook: 06/2014 to 09/2015  

---

## [Wood (Previously known as AMEC Earth & Environmental)](https://www.woodplc.com/) 
> 4490 Beltway Drive, Addison, TX 75001 - (469) 828-4100  
Laboratory Technician 08/2013 to 03/2014  


1. Performed laboratory testing on concrete and soil samples.  
1. Collected and maintained data reports detailing project samples.  
1. Managed test scheduling and preserving samples in limestone storage tanks  

• Certifications:  
[ACI Concrete Technicain certification](https://www.concrete.org/certification/certificationprograms.aspx?m=details&pgm=Field%20Concrete%20Testing&cert=Concrete%20Field%20Testing%20Technician%20-%20Grade%20I)  

---
# Education  
Associate of Arts: Computer Science  
North Lake College - Irving, TX: 2012-2014  
 - Focused on coursework in Mathematics and Intro to C++  



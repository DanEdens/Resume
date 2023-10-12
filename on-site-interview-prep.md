# General Questions.

1. What types of tests do we run. 
    1. How are results measured and recorded
    1. What are the bottlenecks with reporting and comparing.
    
1. How are software updates handled? 
    1. who designs and releases the tablet software.
    

# Questions to ask while testing scanners 

1. Signals, what types and frequency. 
    1. expected range and observed range. 


1. Hardware's interfaces 
    1. tablet Gui 
        1. Can I install other frameworks to interact with it?
        1. Do the tablets have an internet connection?
            1. IF True:
                Will I be able to install tools for reporting and UI Automation.  
            1. ELSE: 
                can I use a local network and mirrored mqtt brokers to collect results for connecting to TestRail/Jira API 
    
    1. Debug options
        1. Hardware serial console?
        1. Port types, cost per unit, reading about past hardware issues?



# General Questions
    1. What types of tests do we run?
        1. How are results measured and recorded?
        1. What are the bottlenecks with reporting and comparing?
    1. How are software updates handled?
        1. Who designs and releases the tablet software?

# Questions to Ask While Testing Scanners
1. What types and frequency of signals are used?

1. What is the expected range and what is the observed range?
    1. How are the hardware's interfaces designed?

    1. Tablet GUI:
 
        1. Can I install other frameworks to interact with it?
        1. Do the tablets have an internet connection?
            1. IF YES:
                1. Will I be able to install tools for reporting and UI Automation?
            1. IF NO:
                1. Can I use a local network and mirrored MQTT brokers to collect results for connecting to TestRail/Jira API?
1. Debug options:
    1. Is there a hardware serial console?
    1. What are the port types, cost per unit, and where can I read about past hardware issues?

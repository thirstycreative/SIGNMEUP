package com.shehacks.signmeup;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class MainController {

    @GetMapping("/")
    String welcome() {
        return "welcome";
    }
}

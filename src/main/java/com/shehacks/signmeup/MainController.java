package com.shehacks.signmeup;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class MainController {

    @GetMapping(value = "/")
    String welcome(@RequestParam(value = "search", required = false) String search, Model model) {
        if ("hello".equalsIgnoreCase(search)) {
            model.addAttribute("videos", "http://media.auslan.org.au/mp4video/33/33460_1.mp4");
        }
        return "welcome";
    }


}

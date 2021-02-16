<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://cdn.static.runoob.com/libs/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/css/materialize.min.css" />
    <script src="http://cdn.static.runoob.com/libs/jquery/2.1.1/jquery.min.js"></script>
    <script src="http://cdn.static.runoob.com/libs/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/js/materialize.min.js"></script>
    <script>
        $(document).ready(function () {
            $('select').formSelect();
        });
    </script>
    <style>
        html, body, .container {
            height: 100%;
            font-family: Lato;
            align-items: center;
            justify-content: center;
            text-align: center;
            /*position: relative;*/
        }

        .container {
            padding-top: 4%;
            display: inline-block;
            align-items: center;
            justify-content: center;
            text-align: center;
            min-height: 100%;
            overflow: auto;
            /*position: relative;*/
        }

        .btn1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <div class="row">
                <div class="event" style="font-weight:bold">
                    Event:
                </div>
                <div class="input-field col s12" style="border: 1px solid gray">
                    <select id="eventstr" name="D1" runat="server">
                        <option value="100yd">100yd</option>
                        <option value="100m">100m</option>
                        <option value="200m">200m</option>
                        <option value="400m">400m</option>
                        <option value="800m">800m</option>
                        <option value="1500m">1500m</option>
                        <option value="One Mile">One Mile</option>
                        <option value="5000m">5000m</option>
                        <option value="200m">10000m</option>
                        <option value="Marathon">Marathon</option>
                        <option value="110m HH">110m HH</option>
                        <option value="400m IH">400m IH</option>
                        <option value="3000m SC">3000m SC</option>
                        <option value="400m Relay">400m Relay</option>
                        <option value="1600m Relay">1600m Relay</option>
                    </select>
                </div>
            </div>
            <%--Time (Format = min:sec.ms [Example: 4:30.574] ) OR Throw Distance (in feet [Example: 5'6" input 5.5] ):--%>
            <h4 class="alert alert-danger" id="alert" style="font-weight:bold;display:none" runat="server"></h4>
            <div class="row">
                <div class="event" style="font-weight:bold">
                    Time:
                </div>
                <div class="input-field col s4" style="border: 1px solid gray">
                    <select id="hour" name="D2" runat="server">
                        <option value="0">0</option>
                        <option value="1">1</option>
                        <option value="2">2</option>
                        <option value="3">3</option>
                        <option value="4">4</option>
                        <option value="5">5</option>
                        <option value="6">6</option>
                        <option value="7">7</option>
                        <option value="8">8</option>
                        <option value="9">9</option>
                        <option value="10">10</option>
                        <option value="11">11</option>
                        <option value="12">12</option>
                        <option value="13">13</option>
                        <option value="14">14</option>
                        <option value="15">15</option>
                        <option value="16">16</option>
                        <option value="17">17</option>
                        <option value="18">18</option>
                        <option value="19">19</option>
                        <option value="20">20</option>
                        <option value="21">21</option>
                        <option value="22">22</option>
                        <option value="23">23</option>
                        <option value="24">24</option>
                    </select>
                </div>
                <div class="input-field col s4" style="border: 1px solid gray">
                    <select id="minute" name="D3" runat="server">
                        <option value="0">0</option>
                        <option value="1">1</option>
                        <option value="2">2</option>
                        <option value="3">3</option>
                        <option value="4">4</option>
                        <option value="5">5</option>
                        <option value="6">6</option>
                        <option value="7">7</option>
                        <option value="8">8</option>
                        <option value="9">9</option>
                        <option value="10">10</option>
                        <option value="11">11</option>
                        <option value="12">12</option>
                        <option value="13">13</option>
                        <option value="14">14</option>
                        <option value="15">15</option>
                        <option value="16">16</option>
                        <option value="17">17</option>
                        <option value="18">18</option>
                        <option value="19">19</option>
                        <option value="20">20</option>
                        <option value="21">21</option>
                        <option value="22">22</option>
                        <option value="23">23</option>
                        <option value="24">24</option>
                        <option value="25">25</option>
                        <option value="26">26</option>
                        <option value="27">27</option>
                        <option value="28">28</option>
                        <option value="29">29</option>
                        <option value="30">30</option>
                        <option value="31">31</option>
                        <option value="32">32</option>
                        <option value="33">33</option>
                        <option value="34">34</option>
                        <option value="35">35</option>
                        <option value="36">36</option>
                        <option value="37">37</option>
                        <option value="38">38</option>
                        <option value="39">39</option>
                        <option value="40">40</option>
                        <option value="41">41</option>
                        <option value="42">42</option>
                        <option value="43">43</option>
                        <option value="44">44</option>
                        <option value="45">45</option>
                        <option value="46">46</option>
                        <option value="47">47</option>
                        <option value="48">48</option>
                        <option value="49">49</option>
                        <option value="50">50</option>
                        <option value="51">51</option>
                        <option value="52">52</option>
                        <option value="53">53</option>
                        <option value="54">54</option>
                        <option value="55">55</option>
                        <option value="56">56</option>
                        <option value="57">57</option>
                        <option value="58">58</option>
                        <option value="59">59</option>
                    </select>
                </div>
                <div class="input-field col s4" style="border: 1px solid gray">
                    <select id="second" name="D4" runat="server">
                        <option value="0">0</option>
                        <option value="1">1</option>
                        <option value="2">2</option>
                        <option value="3">3</option>
                        <option value="4">4</option>
                        <option value="5">5</option>
                        <option value="6">6</option>
                        <option value="7">7</option>
                        <option value="8">8</option>
                        <option value="9">9</option>
                        <option value="10">10</option>
                        <option value="11">11</option>
                        <option value="12">12</option>
                        <option value="13">13</option>
                        <option value="14">14</option>
                        <option value="15">15</option>
                        <option value="16">16</option>
                        <option value="17">17</option>
                        <option value="18">18</option>
                        <option value="19">19</option>
                        <option value="20">20</option>
                        <option value="21">21</option>
                        <option value="22">22</option>
                        <option value="23">23</option>
                        <option value="24">24</option>
                        <option value="25">25</option>
                        <option value="26">26</option>
                        <option value="27">27</option>
                        <option value="28">28</option>
                        <option value="29">29</option>
                        <option value="30">30</option>
                        <option value="31">31</option>
                        <option value="32">32</option>
                        <option value="33">33</option>
                        <option value="34">34</option>
                        <option value="35">35</option>
                        <option value="36">36</option>
                        <option value="37">37</option>
                        <option value="38">38</option>
                        <option value="39">39</option>
                        <option value="40">40</option>
                        <option value="41">41</option>
                        <option value="42">42</option>
                        <option value="43">43</option>
                        <option value="44">44</option>
                        <option value="45">45</option>
                        <option value="46">46</option>
                        <option value="47">47</option>
                        <option value="48">48</option>
                        <option value="49">49</option>
                        <option value="50">50</option>
                        <option value="51">51</option>
                        <option value="52">52</option>
                        <option value="53">53</option>
                        <option value="54">54</option>
                        <option value="55">55</option>
                        <option value="56">56</option>
                        <option value="57">57</option>
                        <option value="58">58</option>
                        <option value="59">59</option>
                    </select>
                </div>
            </div>
            <div class="row">
                <p class="col s4">Hour</p>
                <p class="col s4">Minute</p>
                <p class="col s4">Second</p>
            </div>
            <h4 class="alert alert-danger" id="alert2" style="font-weight:bold;display:none" runat="server"></h4>
            <div class="row">
                <div class="event" style="font-weight:bold">
                    Percent Range:
                </div>
                <div class="col s4" style="border: 1px solid gray">
                    <select id="from" name="from" runat="server">
                        <option value="1">1%</option>
                        <option value="2">2%</option>
                        <option value="3">3%</option>
                        <option value="4">4%</option>
                        <option value="5">5%</option>
                        <option value="6">6%</option>
                        <option value="7">7%</option>
                        <option value="8">8%</option>
                        <option value="9">9%</option>
                        <option value="10">10%</option>
                        <option value="11">11%</option>
                        <option value="12">12%</option>
                        <option value="13">13%</option>
                        <option value="14">14%</option>
                        <option value="15">15%</option>
                        <option value="16">16%</option>
                        <option value="17">17%</option>
                        <option value="18">18%</option>
                        <option value="19">19%</option>
                        <option value="20">20%</option>
                        <option value="21">21%</option>
                        <option value="22">22%</option>
                        <option value="23">23%</option>
                        <option value="24">24%</option>
                        <option value="25">25%</option>
                        <option value="26">26%</option>
                        <option value="27">27%</option>
                        <option value="28">28%</option>
                        <option value="29">29%</option>
                        <option value="30">30%</option>
                        <option value="31">31%</option>
                        <option value="32">32%</option>
                        <option value="33">33%</option>
                        <option value="34">34%</option>
                        <option value="35">35%</option>
                        <option value="36">36%</option>
                        <option value="37">37%</option>
                        <option value="38">38%</option>
                        <option value="39">39%</option>
                        <option value="40">40%</option>
                        <option value="41">41%</option>
                        <option value="42">42%</option>
                        <option value="43">43%</option>
                        <option value="44">44%</option>
                        <option value="45">45%</option>
                        <option value="46">46%</option>
                        <option value="47">47%</option>
                        <option value="48">48%</option>
                        <option value="49">49%</option>
                        <option value="50">50%</option>
                        <option value="51">51%</option>
                        <option value="52">52%</option>
                        <option value="53">53%</option>
                        <option value="54">54%</option>
                        <option value="55">55%</option>
                        <option value="56">56%</option>
                        <option value="57">57%</option>
                        <option value="58">58%</option>
                        <option value="59">59%</option>
                        <option value="60">60%</option>
                        <option value="61">61%</option>
                        <option value="62">62%</option>
                        <option value="63">63%</option>
                        <option value="64">64%</option>
                        <option value="65">65%</option>
                        <option value="66">66%</option>
                        <option value="67">67%</option>
                        <option value="68">68%</option>
                        <option value="69">69%</option>
                        <option value="70">70%</option>
                        <option value="71">71%</option>
                        <option value="72">72%</option>
                        <option value="73">73%</option>
                        <option value="74">74%</option>
                        <option value="75">75%</option>
                        <option value="76">76%</option>
                        <option value="77">77%</option>
                        <option value="78">78%</option>
                        <option value="79">79%</option>
                        <option value="80">80%</option>
                        <option value="81">81%</option>
                        <option value="82">82%</option>
                        <option value="83">83%</option>
                        <option value="84">84%</option>
                        <option value="85">85%</option>
                        <option value="86">86%</option>
                        <option value="87">87%</option>
                        <option value="88">88%</option>
                        <option value="89">89%</option>
                        <option value="90">90%</option>
                        <option value="91">91%</option>
                        <option value="92">92%</option>
                        <option value="93">93%</option>
                        <option value="94">94%</option>
                        <option value="95">95%</option>
                        <option value="96">96%</option>
                        <option value="97">97%</option>
                        <option value="98">98%</option>
                        <option value="99">99%</option>
                        <option value="100">100%</option>
                    </select>
                </div>
                <div class="col s4" style="border: 1px solid gray">
                    <select id="to" name="to" runat="server">
                        <option value="1">1%</option>
                        <option value="2">2%</option>
                        <option value="3">3%</option>
                        <option value="4">4%</option>
                        <option value="5">5%</option>
                        <option value="6">6%</option>
                        <option value="7">7%</option>
                        <option value="8">8%</option>
                        <option value="9">9%</option>
                        <option value="10">10%</option>
                        <option value="11">11%</option>
                        <option value="12">12%</option>
                        <option value="13">13%</option>
                        <option value="14">14%</option>
                        <option value="15">15%</option>
                        <option value="16">16%</option>
                        <option value="17">17%</option>
                        <option value="18">18%</option>
                        <option value="19">19%</option>
                        <option value="20">20%</option>
                        <option value="21">21%</option>
                        <option value="22">22%</option>
                        <option value="23">23%</option>
                        <option value="24">24%</option>
                        <option value="25">25%</option>
                        <option value="26">26%</option>
                        <option value="27">27%</option>
                        <option value="28">28%</option>
                        <option value="29">29%</option>
                        <option value="30">30%</option>
                        <option value="31">31%</option>
                        <option value="32">32%</option>
                        <option value="33">33%</option>
                        <option value="34">34%</option>
                        <option value="35">35%</option>
                        <option value="36">36%</option>
                        <option value="37">37%</option>
                        <option value="38">38%</option>
                        <option value="39">39%</option>
                        <option value="40">40%</option>
                        <option value="41">41%</option>
                        <option value="42">42%</option>
                        <option value="43">43%</option>
                        <option value="44">44%</option>
                        <option value="45">45%</option>
                        <option value="46">46%</option>
                        <option value="47">47%</option>
                        <option value="48">48%</option>
                        <option value="49">49%</option>
                        <option value="50">50%</option>
                        <option value="51">51%</option>
                        <option value="52">52%</option>
                        <option value="53">53%</option>
                        <option value="54">54%</option>
                        <option value="55">55%</option>
                        <option value="56">56%</option>
                        <option value="57">57%</option>
                        <option value="58">58%</option>
                        <option value="59">59%</option>
                        <option value="60">60%</option>
                        <option value="61">61%</option>
                        <option value="62">62%</option>
                        <option value="63">63%</option>
                        <option value="64">64%</option>
                        <option value="65">65%</option>
                        <option value="66">66%</option>
                        <option value="67">67%</option>
                        <option value="68">68%</option>
                        <option value="69">69%</option>
                        <option value="70">70%</option>
                        <option value="71">71%</option>
                        <option value="72">72%</option>
                        <option value="73">73%</option>
                        <option value="74">74%</option>
                        <option value="75">75%</option>
                        <option value="76">76%</option>
                        <option value="77">77%</option>
                        <option value="78">78%</option>
                        <option value="79">79%</option>
                        <option value="80">80%</option>
                        <option value="81">81%</option>
                        <option value="82">82%</option>
                        <option value="83">83%</option>
                        <option value="84">84%</option>
                        <option value="85">85%</option>
                        <option value="86">86%</option>
                        <option value="87">87%</option>
                        <option value="88">88%</option>
                        <option value="89">89%</option>
                        <option value="90">90%</option>
                        <option value="91">91%</option>
                        <option value="92">92%</option>
                        <option value="93">93%</option>
                        <option value="94">94%</option>
                        <option value="95">95%</option>
                        <option value="96">96%</option>
                        <option value="97">97%</option>
                        <option value="98">98%</option>
                        <option value="99">99%</option>
                        <option value="100">100%</option>
                    </select>
                </div>
                <div class="col s4" style="border: 1px solid gray">
                     <select id="increment" name="inc" runat="server">
                        <option value="0.01">1%</option>
                        <option value="0.05">5%</option>
                        <option value="0.10">10%</option>
                        <option value="0.15">15%</option>
                        <option value="0.20">20%</option>
                        <option value="0.25">25%</option>
                    </select>    
                </div>
            </div>
            <div class="row">
                <p class="col s4">From This %</p>
                <p class="col s4">To This %</p>
                <p class="col s4">Increment</p>
            </div>
            <div class="row">
                <div class="btn1">
                    <asp:Button class="wave-effect waves-light btn" Text="submit" type="submit" runat="server" OnClick="Gen_Table" />
                </div>
            </div>
            <div id="table" runat="server" class="centered">
                <div id="pts" runat="server"></div>
                <%--<asp:Button ID="gen0" Text="generate" Disabled="true" Enabled="false" type="generate" Style="display: block" runat="server" />
            <asp:Button ID="gen1" Text="generate" type="generate" runat="server" Style="display: none" OnClick="Generate_Table" />--%>
            </div>
        </form>
    </div>
</body>
</html>

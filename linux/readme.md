threedp@debian:~$ cd  /
threedp@debian:/$ rm teste.txt
rm: cannot remove 'teste.txt': No such file or directory
threedp@debian:/$ 
threedp@debian:/$ 
threedp@debian:/$ 
threedp@debian:/$ mkdir tt
mkdir: cannot create directory ‘tt’: Permission denied
threedp@debian:/$ ls
bin   home            lib32       media  root  sys  vmlinuz
boot  initrd.img      lib64       mnt    run   tmp  vmlinuz.old
dev   initrd.img.old  libx32      opt    sbin  usr
etc   lib             lost+found  proc   srv   var
threedp@debian:/$ cd home
threedp@debian:/home$ su -
Password: 
root@debian:~# mkdir tt
root@debian:~# 
root@debian:~# 
root@debian:~# 
root@debian:~# 
root@debian:~# rkdir tt
-bash: rkdir: command not found
root@debian:~# rmdir tt
root@debian:~# 
root@debian:~# 
root@debian:~# 
root@debian:~# mkdir tt
root@debian:~# 
root@debian:~# 
root@debian:~# mk teste.txt
-bash: mk: command not found
root@debian:~# 
root@debian:~# 
root@debian:~# 
root@debian:~# 
root@debian:~# 
root@debian:~# ls - s
ls: cannot access '-': No such file or directory
ls: cannot access 's': No such file or directory
root@debian:~# ls -s
total 8
4 nano.save  4 tt
root@debian:~# cd /
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# ls -l
total 60
lrwxrwxrwx   1 root root     7 Feb 12 20:47 bin -> usr/bin
drwxr-xr-x   3 root root  4096 Feb 12 21:26 boot
drwxr-xr-x  17 root root  3180 Mar 11 19:17 dev
drwxr-xr-x 121 root root  4096 Mar 11 19:17 etc
drwxr-xr-x   3 root root  4096 Feb 12 21:26 home
lrwxrwxrwx   1 root root    30 Feb 12 21:17 initrd.img -> boot/initrd.img-4.19.0-8-amd64
lrwxrwxrwx   1 root root    30 Feb 12 20:48 initrd.img.old -> boot/initrd.img-4.19.0-5-amd64
lrwxrwxrwx   1 root root     7 Feb 12 20:47 lib -> usr/lib
lrwxrwxrwx   1 root root     9 Feb 12 20:47 lib32 -> usr/lib32
lrwxrwxrwx   1 root root     9 Feb 12 20:47 lib64 -> usr/lib64
lrwxrwxrwx   1 root root    10 Feb 12 20:47 libx32 -> usr/libx32
drwx------   2 root root 16384 Feb 12 20:47 lost+found
drwxr-xr-x   3 root root  4096 Feb 12 20:47 media
drwxr-xr-x   2 root root  4096 Feb 12 20:47 mnt
drwxr-xr-x   2 root root  4096 Feb 12 20:47 opt
dr-xr-xr-x 145 root root     0 Mar 11 19:17 proc
drwx------   8 root root  4096 Mar 11 19:41 root
drwxr-xr-x  24 root root   640 Mar 11 19:17 run
lrwxrwxrwx   1 root root     8 Feb 12 20:47 sbin -> usr/sbin
drwxr-xr-x   2 root root  4096 Feb 12 20:47 srv
dr-xr-xr-x  13 root root     0 Mar 11 19:16 sys
drwxrwxrwt  16 root root  4096 Mar 11 19:27 tmp
drwxr-xr-x  14 root root  4096 Feb 12 21:22 usr
drwxr-xr-x  11 root root  4096 Feb 12 20:47 var
lrwxrwxrwx   1 root root    27 Feb 12 21:17 vmlinuz -> boot/vmlinuz-4.19.0-8-amd64
lrwxrwxrwx   1 root root    27 Feb 12 20:48 vmlinuz.old -> boot/vmlinuz-4.19.0-5-amd64
root@debian:/# cd /tmp
root@debian:/tmp#  mkdir ifsp
root@debian:/tmp# 
root@debian:/tmp# 
root@debian:/tmp# 
root@debian:/tmp# 
root@debian:/tmp# cd ifsp
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls -la
total 8
drwxr-xr-x  2 root root 4096 Mar 11 19:42 .
drwxrwxrwt 17 root root 4096 Mar 11 19:42 ..
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# pws
-bash: pws: command not found
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# pwd
/tmp/ifsp
root@debian:/tmp/ifsp# cd ..
root@debian:/tmp# ls -l
total 40
drwxr-xr-x 2 root    root    4096 Mar 11 19:42 ifsp
drwx------ 2 root    root    4096 Mar 11 19:17 pulse-PKdhtXMmr18n
drwx------ 3 root    root    4096 Mar 11 19:17 systemd-private-52aa9f556407457299989f6d2d44c8d0-bolt.service-xXgbLJ
drwx------ 3 root    root    4096 Mar 11 19:17 systemd-private-52aa9f556407457299989f6d2d44c8d0-colord.service-uCzLwg
drwx------ 3 root    root    4096 Mar 11 19:17 systemd-private-52aa9f556407457299989f6d2d44c8d0-fwupd.service-GIjVIz
drwx------ 3 root    root    4096 Mar 11 19:17 systemd-private-52aa9f556407457299989f6d2d44c8d0-ModemManager.service-hq4jVb
drwx------ 3 root    root    4096 Mar 11 19:17 systemd-private-52aa9f556407457299989f6d2d44c8d0-rtkit-daemon.service-U0CK0q
drwx------ 3 root    root    4096 Mar 11 19:17 systemd-private-52aa9f556407457299989f6d2d44c8d0-systemd-timesyncd.service-cO4LRe
drwx------ 3 root    root    4096 Mar 11 19:17 systemd-private-52aa9f556407457299989f6d2d44c8d0-upower.service-vGwxVx
drwx------ 2 threedp threedp 4096 Mar 11 19:20 tracker-extract-files.1000
root@debian:/tmp# cd ifsp
root@debian:/tmp/ifsp# ls -l
total 0
root@debian:/tmp/ifsp# ls -la
total 8
drwxr-xr-x  2 root root 4096 Mar 11 19:42 .
drwxrwxrwt 17 root root 4096 Mar 11 19:42 ..
root@debian:/tmp/ifsp# cd .
root@debian:/tmp/ifsp# cd /
root@debian:/# cd etc
root@debian:/etc# 
root@debian:/etc# 
root@debian:/etc# 
root@debian:/etc# 
root@debian:/etc# 
root@debian:/etc# 
root@debian:/etc# cd /tmp/ifsp
root@debian:/tmp/ifsp# cd /etc
root@debian:/etc# ls -l
total 1028
drwxr-xr-x  2 root root    4096 Feb 17 19:33 3270
-rw-r--r--  1 root root    2981 Feb 12 20:47 adduser.conf
-rw-r--r--  1 root root      44 Feb 12 21:26 adjtime
drwxr-xr-x  3 root root    4096 Feb 12 21:22 alsa
drwxr-xr-x  2 root root    4096 Mar  4 20:33 alternatives
-rw-r--r--  1 root root     401 May 19  2019 anacrontab
drwxr-xr-x  4 root root    4096 Feb 12 21:22 apache2
-rw-r--r--  1 root root     433 Oct  1  2017 apg.conf
drwxr-xr-x  3 root root    4096 Feb 12 21:19 apm
drwxr-xr-x  2 root root    4096 Feb 12 20:48 apparmor
drwxr-xr-x  7 root root    4096 Feb 12 21:25 apparmor.d
-rw-r--r--  1 root root     769 Jan 26  2019 appstream.conf
drwxr-xr-x  7 root root    4096 Mar 11 19:22 apt
drwxr-xr-x  3 root root    4096 Feb 12 21:25 avahi
-rw-r--r--  1 root root    1994 Apr 18  2019 bash.bashrc
-rw-r--r--  1 root root      45 Feb 11  2019 bash_completion
-rw-r--r--  1 root root     367 Mar  2  2018 bindresvport.blacklist
drwxr-xr-x  2 root root    4096 May 24  2019 binfmt.d
drwxr-xr-x  2 root root    4096 Feb 12 21:24 bluetooth
-rw-r--r--  1 root root    7439 Mar  9  2018 bogofilter.cf
drwxr-xr-x  3 root root    4096 Feb 12 21:19 ca-certificates
-rw-r--r--  1 root root    5713 Feb 12 21:24 ca-certificates.conf
drwxr-xr-x  2 root root    4096 Feb 12 20:47 calendar
drwxr-s---  2 root dip     4096 Feb 12 21:23 chatscripts
drwxr-xr-x  3 root root    4096 Feb 12 21:20 chromium
drwxr-xr-x  2 root root    4096 Feb 12 21:17 console-setup
drwxr-xr-x  2 root root    4096 Feb 12 21:24 cracklib
drwxr-xr-x  2 root root    4096 Feb 12 21:23 cron.d
drwxr-xr-x  2 root root    4096 Mar  4 21:56 cron.daily
drwxr-xr-x  2 root root    4096 Feb 12 21:17 cron.hourly
drwxr-xr-x  2 root root    4096 Feb 12 21:23 cron.monthly
-rw-r--r--  1 root root    1042 Jun 23  2019 crontab
drwxr-xr-x  2 root root    4096 Feb 12 21:24 cron.weekly
drwxr-xr-x  5 root lp      4096 Mar 11 19:18 cups
drwxr-xr-x  2 root root    4096 Feb 12 21:25 cupshelpers
drwxr-xr-x  4 root root    4096 Feb 12 21:07 dbus-1
-rw-r--r--  1 root root    2969 Feb 26  2019 debconf.conf
-rw-r--r--  1 root root       5 Feb  1 14:07 debian_version
drwxr-xr-x  3 root root    4096 Mar 11 19:22 default
-rw-r--r--  1 root root     604 Jun 26  2016 deluser.conf
drwxr-xr-x  4 root root    4096 Feb 12 20:47 dhcp
drwxr-xr-x  2 root root    4096 Feb 12 21:25 dictionaries-common
drwxr-xr-x  2 root root    4096 Feb 12 20:51 discover.conf.d
-rw-r--r--  1 root root     346 Jan 14  2018 discover-modprobe.conf
-rw-r--r--  1 root root    1131 Nov 20  2016 dleyna-server-service.conf
drwxr-xr-x  4 root root    4096 Mar  4 20:33 dpkg
drwxr-xr-x  3 root root    4096 Feb 12 21:20 emacs
-rw-r--r--  1 root root       0 Feb 12 20:47 environment
drwxr-xr-x  2 root root    4096 Feb 12 21:24 environment.d
drwxr-xr-x  2 root root    4096 Feb 12 21:25 firefox-esr
drwxr-xr-x  4 root root    4096 Feb 12 21:24 fonts
drwxr-xr-x  2 root root    4096 Dec  5  2018 foomatic
-rw-r--r--  1 root root     664 Feb 12 20:47 fstab
-rw-r--r--  1 root root     280 Jun 20  2014 fuse.conf
drwxr-xr-x  3 root root    4096 Feb 12 21:25 fwupd
-rw-r--r--  1 root root    2584 Aug  1  2018 gai.conf
drwxr-xr-x  6 root root    4096 Feb 12 21:25 gdm3
drwxr-xr-x  2 root root    4096 Feb 12 21:25 geoclue
drwxr-xr-x  4 root root    4096 Feb 12 21:21 ghostscript
drwxr-xr-x  3 root root    4096 Feb 12 21:20 glvnd
drwxr-xr-x  2 root root    4096 Feb 12 21:23 gnome
drwxr-xr-x  2 root root    4096 Feb 12 21:25 gnome-chess
drwxr-xr-x  2 root root    4096 Feb 12 21:24 groff
-rw-r--r--  1 root root     950 Feb 12 21:26 group
-rw-r--r--  1 root root     926 Feb 12 21:26 group-
drwxr-xr-x  2 root root    4096 Feb 12 21:26 grub.d
-rw-r-----  1 root shadow   800 Feb 12 21:26 gshadow
-rw-r-----  1 root shadow   778 Feb 12 21:26 gshadow-
drwxr-xr-x  3 root root    4096 Feb 12 21:19 gss
drwxr-xr-x  2 root root    4096 Feb 12 21:24 gtk-3.0
-rw-r--r--  1 root root    5060 Oct 26  2018 hdparm.conf
-rw-r--r--  1 root root       9 Aug  7  2006 host.conf
-rw-r--r--  1 root root       7 Feb 12 20:47 hostname
-rw-r--r--  1 root root     186 Feb 12 20:47 hosts
-rw-r--r--  1 root root     411 Feb 12 21:23 hosts.allow
-rw-r--r--  1 root root     711 Feb 12 21:23 hosts.deny
drwxr-xr-x  2 root root    4096 Feb 12 21:25 hp
drwxr-xr-x  3 root root    4096 Feb 12 21:19 ifplugd
drwxr-xr-x  2 root root    4096 Feb 12 21:25 init.d
drwxr-xr-x  5 root root    4096 Feb 12 21:17 initramfs-tools
-rw-r--r--  1 root root    1748 May  5  2018 inputrc
drwxr-xr-x  2 root root    4096 Feb 12 21:25 insserv.conf.d
drwxr-xr-x  4 root root    4096 Feb 12 20:47 iproute2
-rw-r--r--  1 root root      27 May 13  2019 issue
-rw-r--r--  1 root root      20 May 13  2019 issue.net
drwxr-xr-x  5 root root    4096 Feb 12 20:47 kernel
-rw-r--r--  1 root root     144 Feb 12 21:26 kernel-img.conf
drwxr-xr-x  2 root root    4096 Feb 12 21:23 ldap
-rw-r--r--  1 root root   92439 Mar  4 20:33 ld.so.cache
-rw-r--r--  1 root root      34 Mar  2  2018 ld.so.conf
drwxr-xr-x  2 root root    4096 Mar  4 20:33 ld.so.conf.d
-rw-r--r--  1 root root      26 Jan 13  2018 libao.conf
-rw-r--r--  1 root root     191 Apr 25  2019 libaudit.conf
drwxr-xr-x  3 root root    4096 Feb 12 21:22 libblockdev
drwxr-xr-x  2 root root    4096 Feb 12 21:23 libnl-3
drwxr-xr-x  2 root root    4096 Jun 25  2019 libpaper.d
drwxr-xr-x  2 root root    4096 Feb 12 21:25 libreoffice
drwxr-xr-x  4 root root    4096 Feb 12 21:23 lighttpd
-rw-r--r--  1 root root    2995 May  1  2019 locale.alias
-rw-r--r--  1 root root    9376 Feb 12 20:47 locale.gen
lrwxrwxrwx  1 root root      37 Feb 12 21:17 localtime -> /usr/share/zoneinfo/America/Sao_Paulo
drwxr-xr-x  4 root root    4096 Feb 12 21:20 logcheck
-rw-r--r--  1 root root   10477 Jul 27  2018 login.defs
-rw-r--r--  1 root root     435 Aug 22  2018 logrotate.conf
drwxr-xr-x  2 root root    4096 Feb 12 21:25 logrotate.d
-r--r--r--  1 root root      33 Feb 12 20:47 machine-id
-rw-r--r--  1 root root     111 Mar  2  2019 magic
-rw-r--r--  1 root root     111 Mar  2  2019 magic.mime
-rw-r--r--  1 root root   40631 Mar  4 21:56 mailcap
-rw-r--r--  1 root root     449 Feb  9  2019 mailcap.order
-rw-r--r--  1 root root    5174 Feb 10  2019 manpath.config
drwxr-xr-x  2 root root    4096 Feb 19 20:20 mc
-rw-r--r--  1 root root   24512 Feb  9  2019 mime.types
-rw-r--r--  1 root root     812 Dec 16  2018 mke2fs.conf
drwxr-xr-x  2 root root    4096 Feb  9  2019 modprobe.d
-rw-r--r--  1 root root     195 Feb 12 20:47 modules
drwxr-xr-x  2 root root    4096 Feb 12 21:25 modules-load.d
-rw-r--r--  1 root root     286 May 13  2019 motd
lrwxrwxrwx  1 root root      19 Feb 12 21:26 mtab -> ../proc/self/mounts
drwxr-xr-x  4 root root    4096 Feb 12 21:23 mysql
-rw-r--r--  1 root root    9278 Jun 11  2019 nanorc
drwxr-xr-x  7 root root    4096 Feb 12 20:47 network
drwxr-xr-x  7 root root    4096 Feb 12 21:24 NetworkManager
-rw-r--r--  1 root root      60 Feb 12 20:47 networks
-rw-r--r--  1 root root     553 Feb 12 21:25 nsswitch.conf
drwxr-xr-x  2 root root    4096 Feb 12 21:23 openal
drwxr-xr-x  3 root root    4096 Feb 12 21:25 opt
lrwxrwxrwx  1 root root      21 Feb  1 14:09 os-release -> ../usr/lib/os-release
drwxr-xr-x  2 root root    4096 Feb 12 21:24 PackageKit
-rw-r--r--  1 root root     552 Feb 14  2019 pam.conf
drwxr-xr-x  2 root root    4096 Feb 12 21:25 pam.d
-rw-r--r--  1 root root       7 Feb 12 21:23 papersize
-rw-r--r--  1 root root    2153 Feb 12 21:26 passwd
-rw-r--r--  1 root root    2086 Feb 12 21:26 passwd-
drwxr-xr-x  4 root root    4096 Feb 12 21:19 perl
drwxr-xr-x  4 root root    4096 Feb 12 21:21 pki
drwxr-xr-x  2 root root    4096 Feb 12 21:24 plymouth
drwxr-xr-x  3 root root    4096 Feb 12 21:07 pm
-rw-r--r--  1 root root    7649 Feb 12 21:25 pnm2ppa.conf
drwxr-xr-x  5 root root    4096 Feb 12 21:19 polkit-1
drwxr-xr-x  7 root dip     4096 Feb 12 21:23 ppp
-rw-r--r--  1 root root     767 Mar  4  2016 profile
drwxr-xr-x  2 root root    4096 Feb 12 21:23 profile.d
-rw-r--r--  1 root root    2932 Feb 10  2019 protocols
drwxr-xr-x  3 root root    4096 Feb 12 21:25 pulse
drwxr-xr-x  2 root root    4096 Feb 12 21:24 python
drwxr-xr-x  2 root root    4096 Feb 12 21:19 python2.7
drwxr-xr-x  2 root root    4096 Feb 12 20:48 python3
drwxr-xr-x  2 root root    4096 Feb 12 21:17 python3.7
drwxr-xr-x  2 root root    4096 Feb 12 21:25 rc0.d
drwxr-xr-x  2 root root    4096 Feb 12 21:25 rc1.d
drwxr-xr-x  2 root root    4096 Feb 12 21:25 rc2.d
drwxr-xr-x  2 root root    4096 Feb 12 21:25 rc3.d
drwxr-xr-x  2 root root    4096 Feb 12 21:25 rc4.d
drwxr-xr-x  2 root root    4096 Feb 12 21:25 rc5.d
drwxr-xr-x  2 root root    4096 Feb 12 21:25 rc6.d
drwxr-xr-x  2 root root    4096 Feb 12 21:24 rcS.d
-rw-r--r--  1 root root    3267 Aug 28  2019 reportbug.conf
-rw-r--r--  1 root root     112 Mar 11 19:17 resolv.conf
drwxr-xr-x  3 root root    4096 Feb 12 21:20 resolvconf
lrwxrwxrwx  1 root root      13 Apr 23  2019 rmt -> /usr/sbin/rmt
-rw-r--r--  1 root root     887 Feb 10  2019 rpc
-rw-r--r--  1 root root    1988 Feb 26  2019 rsyslog.conf
drwxr-xr-x  2 root root    4096 Feb 26  2019 rsyslog.d
-rw-r--r--  1 root root    4988 Feb 13  2019 rygel.conf
drwxr-xr-x  3 root root    4096 Feb 12 21:25 sane.d
-rw-r--r--  1 root root    4141 Jul 27  2018 securetty
drwxr-xr-x  4 root root    4096 Feb 12 21:23 security
drwxr-xr-x  2 root root    4096 Feb 12 20:47 selinux
-rw-r--r--  1 root root   10593 Dec 19  2018 sensors3.conf
drwxr-xr-x  2 root root    4096 Feb 12 21:23 sensors.d
-rw-r--r--  1 root root   18774 Feb 10  2019 services
-rw-r-----  1 root shadow  1261 Feb 12 21:26 shadow
-rw-r-----  1 root shadow  1229 Feb 12 21:26 shadow-
-rw-r--r--  1 root root     116 Feb 12 20:47 shells
drwxr-xr-x  2 root root    4096 Feb 12 20:47 skel
drwxr-xr-x  2 root root    4096 Feb 12 21:23 snmp
drwxr-xr-x  4 root root    4096 Feb 12 21:25 speech-dispatcher
drwxr-xr-x  2 root root    4096 Feb 12 21:24 ssh
drwxr-xr-x  4 root root    4096 Feb 12 21:23 ssl
-rw-r--r--  1 root root      21 Feb 12 21:26 subgid
-rw-r--r--  1 root root       0 Feb 12 20:47 subgid-
-rw-r--r--  1 root root      21 Feb 12 21:26 subuid
-rw-r--r--  1 root root       0 Feb 12 20:47 subuid-
-r--r-----  1 root root     669 Feb  2 04:41 sudoers
drwxr-xr-x  2 root root    4096 Feb 12 21:23 sudoers.d
-rw-r--r--  1 root root    2351 May 31  2018 sysctl.conf
drwxr-xr-x  2 root root    4096 Feb 12 21:17 sysctl.d
drwxr-xr-x  5 root root    4096 Feb 12 21:17 systemd
drwxr-xr-x  2 root root    4096 Feb 12 21:17 terminfo
-rw-r--r--  1 root root      18 Feb 12 21:17 timezone
drwxr-xr-x  2 root root    4096 May 24  2019 tmpfiles.d
-rw-r--r--  1 root root    1260 Dec 14  2018 ucf.conf
drwxr-xr-x  4 root root    4096 Feb 12 21:17 udev
drwxr-xr-x  2 root root    4096 Feb 12 21:24 udisks2
drwxr-xr-x  3 root root    4096 Feb 12 21:20 ufw
drwxr-xr-x  2 root root    4096 Feb 12 21:17 update-motd.d
drwxr-xr-x  2 root root    4096 Feb 12 21:24 UPower
-rw-r--r--  1 root root    1523 Feb 23  2018 usb_modeswitch.conf
drwxr-xr-x  2 root root    4096 Feb 23  2018 usb_modeswitch.d
-rw-r--r--  1 root root      51 Jan 20  2019 vdpau_wrapper.cfg
drwxr-xr-x  2 root root    4096 Feb 12 20:47 vim
drwxr-xr-x  5 root root    4096 Feb 12 21:20 vulkan
-rw-r--r--  1 root root    4942 Apr  5  2019 wgetrc
drwxr-xr-x  2 root root    4096 Feb 12 21:24 wpa_supplicant
drwxr-xr-x 10 root root    4096 Feb 12 21:25 X11
-rw-r--r--  1 root root     642 Mar  1  2019 xattr.conf
drwxr-xr-x  5 root root    4096 Feb 12 21:22 xdg
root@debian:/etc# cd ..
root@debian:/# mkdir ifsp
root@debian:/# cd etc
root@debian:/etc# cd ..
root@debian:/# cd tmp
root@debian:/tmp# cd ifsp
root@debian:/tmp/ifsp# cd /ifsp
root@debian:/ifsp# 
root@debian:/ifsp# 
root@debian:/ifsp# 
root@debian:/ifsp# 
root@debian:/ifsp# 
root@debian:/ifsp# rmdir ifsp
rmdir: failed to remove 'ifsp': No such file or directory
root@debian:/ifsp# 
root@debian:/ifsp# 
root@debian:/ifsp# 
root@debian:/ifsp# cd ..
root@debian:/# rmdir ifsp
root@debian:/# ls -l
total 60
lrwxrwxrwx   1 root root     7 Feb 12 20:47 bin -> usr/bin
drwxr-xr-x   3 root root  4096 Feb 12 21:26 boot
drwxr-xr-x  17 root root  3180 Mar 11 19:17 dev
drwxr-xr-x 121 root root  4096 Mar 11 19:17 etc
drwxr-xr-x   3 root root  4096 Feb 12 21:26 home
lrwxrwxrwx   1 root root    30 Feb 12 21:17 initrd.img -> boot/initrd.img-4.19.0-8-amd64
lrwxrwxrwx   1 root root    30 Feb 12 20:48 initrd.img.old -> boot/initrd.img-4.19.0-5-amd64
lrwxrwxrwx   1 root root     7 Feb 12 20:47 lib -> usr/lib
lrwxrwxrwx   1 root root     9 Feb 12 20:47 lib32 -> usr/lib32
lrwxrwxrwx   1 root root     9 Feb 12 20:47 lib64 -> usr/lib64
lrwxrwxrwx   1 root root    10 Feb 12 20:47 libx32 -> usr/libx32
drwx------   2 root root 16384 Feb 12 20:47 lost+found
drwxr-xr-x   3 root root  4096 Feb 12 20:47 media
drwxr-xr-x   2 root root  4096 Feb 12 20:47 mnt
drwxr-xr-x   2 root root  4096 Feb 12 20:47 opt
dr-xr-xr-x 145 root root     0 Mar 11 19:17 proc
drwx------   8 root root  4096 Mar 11 19:41 root
drwxr-xr-x  24 root root   640 Mar 11 19:17 run
lrwxrwxrwx   1 root root     8 Feb 12 20:47 sbin -> usr/sbin
drwxr-xr-x   2 root root  4096 Feb 12 20:47 srv
dr-xr-xr-x  13 root root     0 Mar 11 19:42 sys
drwxrwxrwt  17 root root  4096 Mar 11 19:42 tmp
drwxr-xr-x  14 root root  4096 Feb 12 21:22 usr
drwxr-xr-x  11 root root  4096 Feb 12 20:47 var
lrwxrwxrwx   1 root root    27 Feb 12 21:17 vmlinuz -> boot/vmlinuz-4.19.0-8-amd64
lrwxrwxrwx   1 root root    27 Feb 12 20:48 vmlinuz.old -> boot/vmlinuz-4.19.0-5-amd64
root@debian:/# cd tmp/ifsp
root@debian:/tmp/ifsp# ls -l
total 0
root@debian:/tmp/ifsp# touch arq1.txt
root@debian:/tmp/ifsp# touch arq2.txt
root@debian:/tmp/ifsp# touch arq3.txt
root@debian:/tmp/ifsp# ls -l
total 0
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq1.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq2.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq3.txt
root@debian:/tmp/ifsp# mkdir diretorio1
root@debian:/tmp/ifsp# mkdir diretorio2
root@debian:/tmp/ifsp# mkdir diretorio3
root@debian:/tmp/ifsp# touch diretorio1/aula3.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# touch /tmp/ifsp/diretorio1/aula4.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls -l diretorio1
total 0
-rw-r--r-- 1 root root 0 Mar 11 19:58 aula3.txt
-rw-r--r-- 1 root root 0 Mar 11 19:58 aula4.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# rmdir diretorio1/
rmdir: failed to remove 'diretorio1/': Directory not empty
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# rm -r diretorio1/
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# rm -rf diretorio1/
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls
arq1.txt  arq2.txt  arq3.txt  diretorio2  diretorio3
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# touch arql.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls -l arq*
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq1.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq2.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq3.txt
-rw-r--r-- 1 root root 0 Mar 11 20:07 arql.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls -l arq[1-z]*
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq1.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq2.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq3.txt
-rw-r--r-- 1 root root 0 Mar 11 20:07 arql.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls -l arq[1-4]*
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq1.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq2.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq3.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls -l arq*.t*
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq1.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq2.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq3.txt
-rw-r--r-- 1 root root 0 Mar 11 20:07 arql.txt
root@debian:/tmp/ifsp# touch arq4.tx
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# touch arq4.xt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls -l arq*.t*
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq1.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq2.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq3.txt
-rw-r--r-- 1 root root 0 Mar 11 20:09 arq4.tx
-rw-r--r-- 1 root root 0 Mar 11 20:07 arql.txt
root@debian:/tmp/ifsp# ls -l arq*.t*
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq1.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq2.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq3.txt
-rw-r--r-- 1 root root 0 Mar 11 20:09 arq4.tx
-rw-r--r-- 1 root root 0 Mar 11 20:07 arql.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls -l arq*.*x
-rw-r--r-- 1 root root 0 Mar 11 20:09 arq4.tx
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls -l arq*.?x?
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq1.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq2.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq3.txt
-rw-r--r-- 1 root root 0 Mar 11 20:07 arql.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# ls -l arq*.*x?
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq1.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq2.txt
-rw-r--r-- 1 root root 0 Mar 11 19:57 arq3.txt
-rw-r--r-- 1 root root 0 Mar 11 20:09 arq4.xt
-rw-r--r-- 1 root root 0 Mar 11 20:07 arql.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# rm -rf arq*   ####
root@debian:/tmp/ifsp# ls -la
total 16
drwxr-xr-x  4 root root 4096 Mar 11 20:12 .
drwxrwxrwt 17 root root 4096 Mar 11 19:42 ..
drwxr-xr-x  2 root root 4096 Mar 11 19:57 diretorio2
drwxr-xr-x  2 root root 4096 Mar 11 19:57 diretorio3
root@debian:/tmp/ifsp# rm -rf arq *
root@debian:/tmp/ifsp# ls -la
total 8
drwxr-xr-x  2 root root 4096 Mar 11 20:13 .
drwxrwxrwt 17 root root 4096 Mar 11 19:42 ..
root@debian:/tmp/ifsp# ]
-bash: ]: command not found
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# unset history file
root@debian:/tmp/ifsp# set AA = blablabla
root@debian:/tmp/ifsp# echo $AA

root@debian:/tmp/ifsp# unset history.file
-bash: unset: `history.file': not a valid identifier
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# echo hystory
hystory
root@debian:/tmp/ifsp# echo $hystory

root@debian:/tmp/ifsp# echo $history

root@debian:/tmp/ifsp# echo $history.file
.file
root@debian:/tmp/ifsp# cat /root/.bash_history
-su
su
exit
exit
sudo apt-get install x3270
ls
ls
clear
ls -la
cd .profile
clear
nano /etc/apt/sources.list
nano /etc/apt/sources.list
nano /etc/apt/sources.list
nano /etc/apt/sources.list
nano /etc/apt/sources.list
apt-get update
apt update
nano /etc/apt/sources.list
apt update
nano /etc/apt/sources.list
apt update
clear
apt install mc
apt install x3270
x3270
clear
apt search
apt search game
apt search x3270
apt show x3270
x3270
clear
ifconfig
ifconfig
ifconfig
sudo ifconfig
exi
ip addr
apt install net-tools
ifconfig
clear
clear
clear
clear
ifconfig wlan0
apt search wlan
ifconfig
ifsonfig enp0s3
ifsonfig enp
ifsonfig enp0
ifsonfig l0
ifsonfig -a
ifconfig -a
ifconfig enp0s3
hostname
hostname tiozao
hostname
cat /etc/resolv.conf
nameserver 8.8.8.8
clear
cat /etc/resolv.conf
vim /etc/resolv.conf
nano /etc/resolv.conf
route
ssh z53907@192.86.32.67
apt install npm
npm i -g @zowe/cli@latest --ignore-scripts
zowe profiles create zosmf-profile --help
clear
zowe profiles create zosmf-profile zowe-tutorial --host 192.86.32.67 --port 443 --user z53907 --password xErife
zowe zosmf check status
apt search vs
ls
cd /
ls
cd /homr
cd /home
ls
cd threedp
cd
ls
cd /home/threedp/Downloads
ls
dpkg -i code_1.42.1-1581432938_amd64.deb 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# mv /etc/apt/arq.txt .
mv: cannot stat '/etc/apt/arq.txt': No such file or directory
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# mv arq.txt arq0.txt
mv: cannot stat 'arq.txt': No such file or directory
root@debian:/tmp/ifsp# mkdir arq.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# mv arq.txt arq0.txt
root@debian:/tmp/ifsp# 
